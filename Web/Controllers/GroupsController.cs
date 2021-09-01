using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.Common;
using MVC.DataAccess;
using MVC.Web.Models.Group;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using System;
using System.Linq;

namespace Controllers
{
    [Route("/courses/{idCourse}/[controller]/")]    
    public class GroupsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<GroupsController> _localizer;
        private readonly ILogger<GroupsController> _logger;
        public GroupsController(IUnitOfWork unitOfWork, IStringLocalizer<GroupsController> localizer,
            ILogger<GroupsController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet("/courses/{idCourse}/groups")]
        [Breadcrumb("Groups")]
        public IActionResult Groups(int idCourse, string name, int page = 1, GroupSortState sortOrder = GroupSortState.NameAsc)
        {                      
            int pageSize = 5;
            Course course = _unitOfWork.Courses.GetById(idCourse);
            if (course == null)
                return NotFound();
            ViewBag.Course = course;

            IQueryable<Group> groups = _unitOfWork.Groups.GetAll().Where(x => x.CourseId == idCourse);
            if (!String.IsNullOrEmpty(name))
            {
                groups = groups.Where(p => p.Name.Contains(name));
            }

            switch (sortOrder)
            {
               case GroupSortState.NameDesc:
                    groups = groups.OrderByDescending(s => s.Name);
                    break;               
                default:
                    groups = groups.OrderBy(s => s.Name);
                    break;
            }

            var count = groups.Count();
            var items = groups.Skip((page - 1) * pageSize).Take(pageSize);

            GroupIndexViewModel viewModel = new GroupIndexViewModel
            {
                PageViewModel = new GroupPageViewModel(count, page, pageSize),
                SortViewModel = new GroupSortViewModel(sortOrder),
                FilterViewModel = new GroupFilterViewModel(name),
                Groups = items
            };

            ViewData["PageSize"] = pageSize;

            return View("Groups", viewModel);
        }        

        [HttpGet("/courses/{idCourse}/groups/edit/{idGroup}")]
        [Breadcrumb("Edit", FromAction = "Groups")]
        public IActionResult GetEditGroup(int idCourse, int idGroup)
        {
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();
            ViewData["Courses"] = _unitOfWork.Courses.GetAll();
            ViewBag.CourseId = idCourse;
            return View("EditGroup", group);
        }

        [HttpPost]
        [Route("/groups/EditGroup")]
        public IActionResult EditGroup(Group group)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(group.Name))
            {
                ModelState.AddModelError(nameof(group.Name), _localizer["EmptyName"]);
            }
            if (group.CourseId == 0)
            {
                ModelState.AddModelError(nameof(group.CourseId), _localizer["NotSelectedCourse"]);
            }


            if (ModelState.IsValid)
            {
                _unitOfWork.Groups.Update(group);
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertEditSuccess"].Value;
                TempData["AlertStatus"] = true;
                return Redirect($"/courses/{group.CourseId}/groups");
            }
            else
            {
                ViewData["Courses"] = _unitOfWork.Courses.GetAll();
                ViewBag.CourseId = group.CourseId;
                return View(group);
            }
        }

        [HttpGet("/courses/{idCourse}/groups/delete/{idGroup}")]
        public IActionResult DeleteGroup(int idCourse, int idGroup)
        {
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);

            if (course == null || group == null || course.Id != group.CourseId)
            {
                TempData["AlertMessage"] = _localizer["AlertRemoveNotFound"].Value;
                TempData["AlertStatus"] = false;                
            }
            else
            {
                int studentsCount = _unitOfWork.Students.GetAll().Where(x => x.GroupId == group.Id).Count();
                if (studentsCount != 0)
                {
                    TempData["AlertMessage"] = _localizer["AlertNotEmptyGroup"].Value;
                    TempData["AlertStatus"] = false;
                }
                else
                {
                    _unitOfWork.Groups.Remove(group.Id);
                    _unitOfWork.Save();
                    TempData["AlertMessage"] = _localizer["AlertRemoveSuccess"].Value;
                    TempData["AlertStatus"] = true;
                }
            }
            return Redirect($"/courses/{group.CourseId}/groups");
        }

        [HttpGet]
        [Route("/groups/create")]
        [Breadcrumb("Create", FromAction = "Groups")]
        public IActionResult Create(int idCourse)
        {
            ViewData["Courses"] = _unitOfWork.Courses.GetAll();
            ViewBag.CourseId = idCourse;
            return View();
        }

        [HttpPost]
        [Route("/groups/create")]
        public IActionResult Create(Group group)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(group.Name))
            {
                ModelState.AddModelError(nameof(group.Name), _localizer["EmptyName"]);
            }
            if (group.CourseId == 0)
            {
                ModelState.AddModelError(nameof(group.CourseId), _localizer["NotSelectedCourse"]);
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Groups.Create(group);
                _unitOfWork.Save();
                TempData["AlertMessage"] = _localizer["AlertCreateSuccess"].Value;
                TempData["AlertStatus"] = true;
                return Redirect($"/courses/{group.CourseId}/groups");
            }
            else
            {
                ViewData["Courses"] = _unitOfWork.Courses.GetAll();
                ViewBag.CourseId = group.CourseId;
                return View(group);
            }
        }
    }
}
