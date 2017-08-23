using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    public class ProductController : Controller
    {
        private Models.MyMvcAjax _dbcontext;

        public ProductController()
        {
            _dbcontext=new Models.MyMvcAjax();
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = _dbcontext.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

       // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var prod = _dbcontext.Products.SingleOrDefault(e => e.Id == id);
            return Json(prod,JsonRequestBehavior.AllowGet);

        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var prod=new Product();
            return View(prod);
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
