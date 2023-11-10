using AttributeRoutingDemoInMVC.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace AttributeRoutingDemoInMVC.Controllers
{
    [RoutePrefix("students")]
    public class StudentsController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Pranaya" },
            new Student() { Id = 2, Name = "Priyanka" },
            new Student() { Id = 3, Name = "Anurag" },
            new Student() { Id = 4, Name = "Sambit" }
        };


        [HttpGet]
        [Route("{studentID:int}")]
        public ActionResult GetStudentDetails(int studentID)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
            return View(studentDetails);
        }

        [HttpGet]
        [Route("{studentName:alpha}")]
        public ActionResult GetStudentDetails(string studentName)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Name == studentName);
            return View(studentDetails);
        }


        [HttpGet]
        [Route]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }


        //[HttpGet]
        //[Route("{studentID:int}")]
        //public ActionResult GetStudentByID(int studentID)
        //{
        //    Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
        //    return View(studentDetails);
        //}


        [HttpGet]
        [Route("{studentID}/courses")]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();

            if (studentID == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (studentID == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };

            ViewBag.CourseList = CourseList;

            return View();
        }
    }
}
