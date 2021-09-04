using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using SmartBreadcrumbs.Nodes;
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

            #region BreadCrumbs
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"], false);
            var node2 = new MvcBreadcrumbNode("Index", "Courses", "404", false)
            {
                Parent = node1
            };                
            ViewData["BreadcrumbNode"] = node2;
            #endregion

            return View("Error");
        }
    }
}
