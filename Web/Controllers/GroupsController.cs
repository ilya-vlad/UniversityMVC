using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MVC.Common;
using MVC.DataAccess;
using MVC.Web.Models.Group;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    [Route("/courses/{idCourse}/[controller]/")]    
    public class GroupsController : BaseController<GroupsController>
    {
        public GroupsController(IUnitOfWork unitOfWork, IStringLocalizer<GroupsController> localizer,
             ILogger<GroupsController> logger) : base(unitOfWork, localizer, logger)
        {

        }

        [HttpGet("/courses/{idCourse}/groups")]        
        public IActionResult Index(int idCourse, string name, int page = 1, int pageSize = 5, 
            GroupSortState sortOrder = GroupSortState.NameAsc)
        {
            var listPageSizes = new List<int>() { 5, 10, 20 };

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
                Items = items
            };

            if (items.Count() == 0)
            {
                ViewData["NoResults"] = _localizer["NoResults"];
            }

            ViewBag.SortState = sortOrder;
            ViewData["PageSize"] = pageSize;           
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course);
            ViewBag.ListPageSizes = listPageSizes;

            return View(viewModel);
        }        

        [HttpGet("/courses/{idCourse}/groups/edit/{idGroup}")]        
        public IActionResult GetGroup(int idCourse, int idGroup)
        {            
            Course course = _unitOfWork.Courses.GetById(idCourse);
            Group group = _unitOfWork.Groups.GetById(idGroup);
            if (course == null || course.Id != group.CourseId)
                return NotFound();
            ViewData["Courses"] = _unitOfWork.Courses.GetAll();
            ViewBag.CourseId = idCourse;
            ViewBag.OldName = group.Name;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, group.Name);

            return View("Edit", group);
        }

        [HttpPost]
        [Route("/groups/edit")]
        public IActionResult Edit(Group group)
        {
            if (!string.IsNullOrEmpty(group.Name))
                group.Name = group.Name.Trim();
            ModelState.Clear();
            if (string.IsNullOrEmpty(group.Name))
            {
                ModelState.AddModelError(nameof(group.Name), _localizer["EmptyName"]);
            }
            if (_unitOfWork.Groups.GetAll().Where(x => x.Name == group.Name && x.Id != group.Id).Count() > 0)
            {
                ModelState.AddModelError(nameof(group.Name), _localizer["AlreadyExistName"]);
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
            
            ViewData["Courses"] = _unitOfWork.Courses.GetAll();
            ViewBag.CourseId = group.CourseId;
            Group editableGroup = _unitOfWork.Groups.GetById(group.Id);
            Course course = _unitOfWork.Courses.GetById(group.CourseId);
            ViewBag.OldName = editableGroup.Name;
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, editableGroup.Name);
            return View(group);
            
        }

        [HttpGet("/courses/{idCourse}/groups/delete/{idGroup}")]
        public IActionResult Delete(int idCourse, int idGroup)
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
        public IActionResult Create(int idCourse)
        {
            Course course = _unitOfWork.Courses.GetById(idCourse);
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, _localizer["CreateGroup"]);
            ViewData["Courses"] = _unitOfWork.Courses.GetAll();
            ViewBag.CourseId = idCourse;
            return View();
        }

        [HttpPost]
        [Route("/groups/create")]
        public IActionResult Create(Group group)
        {
            if(!string.IsNullOrEmpty(group.Name))
                group.Name = group.Name.Trim();
            ModelState.Clear();
            if (string.IsNullOrEmpty(group.Name))
            {
                ModelState.AddModelError(nameof(group.Name), _localizer["EmptyName"]);
            }
            if (_unitOfWork.Groups.GetAll().Where(x => x.Name == group.Name).Count() > 0)
            {
                ModelState.AddModelError(nameof(group.Name), _localizer["AlreadyExistName"]);
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
            
            ViewData["Courses"] = _unitOfWork.Courses.GetAll();            
            ViewBag.CourseId = group.CourseId;
            Course course = _unitOfWork.Courses.GetById(group.CourseId);
            ViewData["BreadcrumbNode"] = GetBreadCrumbs(course, _localizer["CreateGroup"]);            

            return View(group);            
        }

        private MvcBreadcrumbNode GetBreadCrumbs(Course course, string currentName)
        {
            currentName = currentName == null ? string.Empty : currentName;            
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);
            var node2 = new MvcBreadcrumbNode("Index", "Groups", course.Name)
            {
                RouteValues = new { idCourse=course.Id },
                Parent = node1
            };
            var node3 = new MvcBreadcrumbNode("", "", currentName)
            {
                Parent = node2
            };
            return node3;
        }

        private MvcBreadcrumbNode GetBreadCrumbs(Course course)
        {            
            var node1 = new MvcBreadcrumbNode("Index", "Courses", _localizer["AllCourses"]);
            var node2 = new MvcBreadcrumbNode("", "", course.Name)
            {
                Parent = node1
            };
            return node2;
        }
    }
}
