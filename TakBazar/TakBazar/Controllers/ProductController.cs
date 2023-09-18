using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakBazar.Entites;
using TakBazar.Services;

namespace TakBazar.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productServices = new ProductServices();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string Search)
        {
            var Products = productServices.GetProduct();
            if (!string.IsNullOrEmpty(Search))
                Products = Products.Where(x => !string.IsNullOrEmpty(x.Name) &&  x.Name.ToLower().Contains(Search.ToLower())).ToList();
            return PartialView(Products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {

                productServices.SaveProduct(product);
                return RedirectToAction("ProductTable");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var Product = productServices.GetProduct(ID);
            return PartialView(Product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {

                productServices.Updateproduct(product);
                return RedirectToAction("ProductTable");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            if (productServices.DeleteCategories(ID))
                return RedirectToAction("ProductTable");


            return View();
        }
    }
}