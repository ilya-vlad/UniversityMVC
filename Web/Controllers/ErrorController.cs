using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.DataAccess;
using Services.BreadCrumbs;

namespace Controllers
{
    public class ErrorController : BaseController<ErrorController>
    {
        public ErrorController(IUnitOfWork unitOfWork, IStringLocalizer<ErrorController> localizer,
            ILogger<ErrorController> logger, IBreadCrumbsCreator breadCrumbsCreator) : base(unitOfWork, localizer, logger, breadCrumbsCreator)
        {

        }

        [Route("Error/{codeError}")]
        public IActionResult HttpStatusCodeHandler(int codeError)
        {
            switch (codeError)
            {
                case 404: ViewBag.ErrorMessage = _localizer["404"]; break;
            }
            _breadCrumbsCreator.CreateNodes(ViewData, "Error");
            
            return View("Error");
        }
    }
}
