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
    public class ClassController : Controller
    {
        private readonly IClassRepository _classRepo;
        public ClassController(IClassRepository classRepo)
        {
            _classRepo = classRepo;
        }
        public async Task<IActionResult> Index()
        {
            /* 
            List<Class> classes = new List<Class>();
            Class s1 = new Class { Id = 1, ClassName = "beta" };
            Class s2 = new Class { Id = 2, ClassName = "alpha" };
            Class s3 = new Class { Id = 3, ClassName = "mark3" };
            classes.Add(s1);
            classes.Add(s2);
            classes.Add(s3);
            return View(classes);
            */
            var classes =  await _classRepo.GetClasses();
            return View(classes);
        }
        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Class/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Class model)
        {
            try
            {
                var createResult = _classRepo.CreateClassTable();
                var addResult = _classRepo.AddClass(new Class { ClassName = model.ClassName, ClassDescription = model.ClassDescription });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
