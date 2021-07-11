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

        public IActionResult Editor()
        {
            return View();
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

    }
}
