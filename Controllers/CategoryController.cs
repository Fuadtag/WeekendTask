using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _08_11_2019WeekendTask.Models;


namespace _08_11_2019WeekendTask.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Category

        [HttpGet]
        public ActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            
            
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)

        {
            
            if (context.Categories.Any(c => c.Name == category.Name))
            {
                ModelState.AddModelError("Name", "Eyni adda kateqoriya yaratmaq olmaz!");
            }
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
            
            return View(category);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category dbcat = context.Categories.FirstOrDefault(c => c.Id == id);
            if (dbcat == null)
            {
                return HttpNotFound();
            }
            return View(dbcat);


        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
             if (!context.Categories.Any(c=>c.Id != category.Id && c.Name == category.Name))
            {
                ModelState.AddModelError("name", "Eyni adda kateqoriya yaradıla bilməz");
            }
            if (ModelState.IsValid)
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("index", "category");
            }
            return View(category);
            


        }


        public ActionResult Delete(int id)
        {
           Category dbcat =  context.Categories.FirstOrDefault(c => c.Id == id);
            if (dbcat == null)
            {
                return HttpNotFound();
            }
            context.Categories.Remove(dbcat);
            context.SaveChanges();
            return RedirectToAction("index", "category");
        }
    }
}