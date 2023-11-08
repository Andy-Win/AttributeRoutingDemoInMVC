using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRoutingDemoInMVC.Areas.Teacher.Controllers
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class HomeController : Controller
    {
        // GET: Teacher/Home
        public ActionResult GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Id = 1, Name = "James" },
                new Teacher() { Id = 2, Name = "Patrik" },
                new Teacher() { Id = 3, Name = "Smith" }
            };
            return View(teachers);
        }
    }
}