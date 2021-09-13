using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.DataAccess;

namespace Controllers
{
    public class BaseController<T> : Controller where T : class
    {
        public IUnitOfWork _unitOfWork;
        public readonly IStringLocalizer<T> _localizer;
        public readonly ILogger<T> _logger;

        public BaseController(IUnitOfWork unitOfWork, IStringLocalizer<T> localizer, ILogger<T> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }
    }
}
