using _08_11_2019WeekendTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace _08_11_2019WeekendTask.Controllers
{
    public class ProjectController : BaseController
    {
        // GET: Project
        public ActionResult Index()
        {
            List<Project> projects = context.Projects.ToList();
            
            return View(projects);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View();

        }
        [HttpPost]
        public ActionResult Create(Project project)
        {
            project.PublishDate = DateTime.Now;
            
            if (context.Projects.Any(p => p.Name == project.Name))
            {
                ModelState.AddModelError("name", "Bu adda proyekt mövcuddur");
            }
            if (ModelState.IsValid)
            {

                context.Projects.Add(project);
                context.SaveChanges();
                return RedirectToAction("index", "project");
            }

            return View();
        }
    }
}