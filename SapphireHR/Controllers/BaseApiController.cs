using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    public class BaseApiController : ControllerBase
    {

        [NonAction]
        protected IActionResult CreateApiException(Exception ex)
        {
            return Problem(ex.StackTrace, ex.Source, 500, ex.Message);
        }

    }
}
