using MVCTutorial1.Context;
using MVCTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial1.Controllers
{
    public class ProductController : Controller
    {
        //create new DB
        private StoreContext context = new StoreContext();

        // GET: Product
        public ActionResult Index()
        {
            return View(context.Products.ToList());
        }

        // GET: Product/Details/5
        //int? receives an optional parameter
        public ActionResult Details(int? id)
        {
            if (id == null)//returns an exception
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var product = context.Products.Find(id);
            if (product == null)//redirect to a
                return HttpNotFound();
            return View(product);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)//returns an exception
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var product = context.Products.Find(id);
            if (product == null)//redirect to a
                return HttpNotFound();
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    context.Entry(product).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);               
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)//returns an exception
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var product = context.Products.Find(id);
            if (product == null)//redirect to a
                return HttpNotFound();
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product = context.Products.Find(id);
                    if (product == null)
                    {
                        return HttpNotFound();
                    }
                    context.Products.Remove(product);
                    context.SaveChanges();
                return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View(product);
            }
        }
    }
}
