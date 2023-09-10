using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakBazar.DataBase;
using TakBazar.Entites;
using TakBazar.Services;

namespace TakBazar.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesServices categoryServices = new CategoriesServices();
        [HttpGet]
        public ActionResult Index()
        {
            var Category = categoryServices.GetCategories();
            return View(Category);
        }
        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category catgory)
        {
            categoryServices.SaveCategory(catgory);
            return RedirectToAction("Index", "Category");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryServices.GetCategories(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (categoryServices.UpdateCategories(category))
               return RedirectToAction("Index", "Category");
            return View(category);
        }

        public ActionResult Delete(int ID)
        {
            if (categoryServices.DeleteCategories(ID))
                return RedirectToAction("Index", "Category");
            
            
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Category catgory)
        //{
        //    categoryServices.SaveCategory(catgory);
        //    return View();
        //}
    }
}