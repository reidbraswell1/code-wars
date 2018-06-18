using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeWars.Models;
using CodeWars.Shared;

namespace CodeWars.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student { Id=1, LastName="Elmor", FirstName="Chip", CodeWarsOverallScore=3000 };
            Student s2 = new Student { Id=2, LastName="Bustamonte", FirstName="Stephen", CodeWarsOverallScore=800  };
            Student s3 = new Student { Id=3, LastName="Trey", FirstName="Dunton", CodeWarsOverallScore=877 };
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            return View(students);
        }
       // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
