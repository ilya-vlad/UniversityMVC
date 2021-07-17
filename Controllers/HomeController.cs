using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        UniversityContext db;
        UnitOfWork unitOfWork;
        public HomeController(UniversityContext context)
        {
            this.db = context;
            unitOfWork = new UnitOfWork(db);
        }


        //private GeneralModel GetGeneralModel()
        //{
        //    var model = new GeneralModel();
        //    model.Courses = db.Courses.ToList();
        //    model.Groups = db.Groups.ToList();
        //    model.Students = db.Students.ToList();
        //    return model;
        //}


        public IActionResult Courses()
        {
            var courses = unitOfWork.Courses.GetAll();
            return View(courses);
        }

        public IActionResult Groups(int? id)
        {
            if (id == null) return RedirectToAction("Courses");
            ViewBag.CourseId = id;            
            return View(unitOfWork);
        }

        public IActionResult Students(int? id)
        {
            if (id == null) return RedirectToAction("Courses");
            ViewBag.GroupId = id;           
            return View(unitOfWork);
        }

        public IActionResult AllGroup()
        {
            var groups = unitOfWork.Groups.GetAll();
            return View(groups);
        }

        public IActionResult EditGroup(int? id)
        {
            if (id != null)
            {
                Group group = unitOfWork.Groups.Get(id.Value);
                if (group != null)
                    return View(group);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult EditGroup(Group group)
        {
            unitOfWork.Groups.Update(group);
            unitOfWork.Save();
            var response = new Response();
            response.Message = $"Group {group.Name} updated!";
            response.PathBack = $"Groups/{group.CourseId}";
            return RedirectToAction("ResponseUpdate", "Home", response);
            
        }

        public IActionResult ResponseUpdate(Response response)
        {
            return View(response);
        }
        [HttpGet]
        public IActionResult RemoveGroup(int? id)
        {
            if (id != null)
            {
                Group group = unitOfWork.Groups.Get(id.Value);
                if (group != null)
                    //return RedirectToAction("RemoveGroup", group);
                    return RemoveGroup(group);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult RemoveGroup(Group group)
        {
            var studentsGroup = unitOfWork.Students.GetAll().Where(x => x.GroupId == group.Id);
            var response = new Response();
            response.PathBack = $"Groups/{group.CourseId}";
            if (studentsGroup.Count() != 0)
            {
                response.Message = $"Group {group.Name} contains students!";
            }
            else
            {                
                unitOfWork.Groups.Delete(group.Id);
                unitOfWork.Save();
                response.Message = $"Group {group.Name} deleted!";
            }          
            return RedirectToAction("ResponseRemove", "Home", response);
        }

        public IActionResult ResponseRemove(Response response)
        {
            return View(response);
        }
    }
}
