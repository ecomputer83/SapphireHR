using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiscellaneousController : BaseApiController
    {
        private readonly ILogger _logger;
        IMiscellaneousService _miscellaneousService;

        public MiscellaneousController(ILogger<MiscellaneousController> logger, IMiscellaneousService miscellaneousService)
        {
            _logger = logger;
            _miscellaneousService = miscellaneousService;
        }
    }
}
