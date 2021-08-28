using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class ErrorController : Controller
    {
        private readonly IStringLocalizer<ErrorController> _localizer;       

        public ErrorController(IStringLocalizer<ErrorController> localizer)
        {           
            _localizer = localizer;
        }

        [Route("Error/{codeError}")]
        public IActionResult HttpStatusCodeHandler(int codeError)
        {
            switch (codeError)
            {
                case 404: ViewBag.ErrorMessage = _localizer["404"]; break;
            }
            return View("Error");
        }
    }
}
