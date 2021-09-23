using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.DataAccess;
using Services.BreadCrumbs;

namespace Controllers
{
    public class BaseController<T> : Controller where T : class
    {
        public IUnitOfWork _unitOfWork;
        public readonly IStringLocalizer<T> _localizer;
        public readonly ILogger<T> _logger;
        public IBreadCrumbsCreator _breadCrumbsCreator;       

        public BaseController(IUnitOfWork unitOfWork, IStringLocalizer<T> localizer, ILogger<T> logger, IBreadCrumbsCreator breadCrumbsCreator)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
            _breadCrumbsCreator = breadCrumbsCreator;
        }
    }
}