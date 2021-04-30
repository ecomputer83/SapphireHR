using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaLoginResponse : BaseResponse
    {
        public LoginData data { get; set; }
    }

    public class LoginData
    {
        public string accessToken { get; set; }
        public string expiresIn { get; set; }
    }
}
