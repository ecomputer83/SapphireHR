using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Web.Helpers;
using SapphireHR.Web.Settings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;
        private readonly JwtSecurityTokenSettings _jwt;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;

        public AccountController(
            IConfiguration configuration,
            IUserService userService,
            IEmployeeService employeeService,
        IOptions<JwtSecurityTokenSettings> jwt,
            ILogger<AccountController> logger,
            IMapper mapper
            )
        {

            this._configuration = configuration;
            this._userService = userService;
            this._employeeService = employeeService;
            this._jwt = jwt.Value;
            this._logger = logger;
            this._mapper = mapper;
        }


        [Authorize]
        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> GetUser()
        {
            try
            {
                var userId = HttpContext.User.Identity.Name;

                var user = await _userService.GetUserById(userId);

                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("roles")]
        public async Task<IActionResult> GetRoles()
        {
            try
            {

                var user = await _userService.GetRoles();

                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        /// <summary>
        /// Register an account
        /// </summary>
        /// <param name="model">RegisterViewModel</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<string>), 400)]
        [Route("registerasAdmin")]
        public async Task<IActionResult> RegisterAsAdmin([FromBody] UserViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                var _model = _mapper.Map<UserModel>(model);
                await _userService.CreateUserAsync(_model, new string[] {"Administrator"});

                return Ok();
            }
            catch (Exception ex)
            
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        //[Authorize(Roles = "Administrator")]
        //[HttpPost]
        //[ProducesResponseType(typeof(IEnumerable<string>), 400)]
        //[Route("addUserAsHR")]
        //public async Task<IActionResult> AddUserAsHR([FromBody] UserModel model)
        //{
        //    try
        //    {

        //        if (!ModelState.IsValid)
        //            return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
        //        model.UserType = 2;
        //        model.Password = "password";
        //        model.ConfirmPassword = "password";
        //        await _userService.CreateUserAsync(model, new string[] { "HRAdmin" });

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, ex.Message);
        //        return CreateApiException(ex);
        //    }
        //}
        //[Authorize(Roles = "Administrator")]
        //[HttpPost]
        //[ProducesResponseType(typeof(IEnumerable<string>), 400)]
        //[Route("addUserAsEmployee")]
        //public async Task<IActionResult> AddUserAsEmployee([FromBody] UserModel model)
        //{
        //    try
        //    {

        //        if (!ModelState.IsValid)
        //            return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
        //        model.UserType = 3;
        //        model.Password = "password";
        //        model.ConfirmPassword = "password";
        //        await _userService.CreateUserAsync(model, new string[] { "Employee" });

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, ex.Message);
        //        return CreateApiException(ex);
        //    }
        //}



        /// <summary>
        /// Log into account
        /// </summary>
        /// <param name="model">LoginViewModel</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(TokenModel), 200)]
        [ProducesResponseType(typeof(IEnumerable<string>), 400)]
        [Route("token")]
        public async Task<IActionResult> CreateToken([FromBody] LoginModel model)
        {
            try
            {
                var user = await _userService.FindByEmailAsync(model.Email).ConfigureAwait(false);
                if (user == null)
                    return BadRequest(new string[] { "Invalid credentials." });

                var tokenModel = new TokenModel()
                {
                    HasVerifiedEmail = false
                };



                // Used as user lock
                if (user.IsLockout)
                    return BadRequest(new string[] { "This account has been locked." });

                if (await _userService.CheckPasswordAsync(user, model.Password).ConfigureAwait(false))
                {
                    tokenModel.HasVerifiedEmail = true;
                    tokenModel.User = _mapper.Map<UserModel>(user);
                    tokenModel.Role = (List<string>)await _userService.GetRolesAsync(user).ConfigureAwait(false);
                    if (user.TwoFactorEnabled)
                    {
                        tokenModel.TFAEnabled = true;
                        return Ok(tokenModel);
                    }
                    else
                    {
                        JwtSecurityToken jwtSecurityToken = await CreateJwtToken(user).ConfigureAwait(false);
                        tokenModel.TFAEnabled = false;
                        tokenModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

                        if(user.UserType > 1)
                        {
                            // Employee Service
                            var companyEmployee = await _employeeService.GetCompanyEmployeeByUserId(user.Id);
                            tokenModel.Extra = companyEmployee;
                        }

                        return Ok(tokenModel);
                    }
                }

                return BadRequest(new string[] { "Invalid login attempt." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }



        /// <summary>
        /// Forgot email sends an email with a link containing reset token
        /// </summary>
        /// <param name="model">ForgotPasswordViewModel</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), 400)]
        [Route("forgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] EmailModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _userService.ForgotPassword(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), 400)]
        [Route("addrole")]
        public async Task<IActionResult> AddRole([FromBody] RoleModel model)
        {
            try
            {
                await _userService.AddRole(model.Name);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        /// <summary>
        /// Reset account password with reset token


        /// <summary>
        /// Resend email verification email with token link
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), 400)]
        [Route("resendVerificationEmail")]
        public async Task<IActionResult> resendVerificationEmail([FromBody] EmailModel model)
        {
            try
            {
                await _userService.ResendVerificationEmail(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<string>), 400)]
        [Route("resetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _userService.ResetPassword(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete]
        [Route("removeuser/{Id}")]
        public async Task<IActionResult> RemoveUser(string Id)
        {
            try
            {
                await _userService.RemoveUser(Id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        private async Task<JwtSecurityToken> CreateJwtToken(UserModel user)
        {
            var userClaims = await _userService.GetClaimsAsync(user).ConfigureAwait(false);
            var roles = await _userService.GetRolesAsync(user).ConfigureAwait(false);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }

            string ipAddress = IpHelper.GetIpAddress();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Id),
                new Claim(ClaimTypes.Name, user.Id),
                new Claim("utype", user.UserType.ToString()),
                new Claim("uid", user.Id),
                new Claim("ip", ipAddress)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(3),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }
    }
}
