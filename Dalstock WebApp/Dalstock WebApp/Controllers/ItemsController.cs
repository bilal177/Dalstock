using BL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dalstock_WebApp.Controllers
{
    public class ItemsController : Controller
    {
        ItemManagerService manager = new ItemManager();
        // GET: Items
        public ActionResult Index()
        {
            var items = manager.GetItems().ToList() ;
            return View(items);
        }

        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,Item item)
        {
            try
            {
                if (Request.Form["submitbtn"] != null)
                {
                    manager.AddItem(item);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Items/Edit/5
        public ActionResult Edit(string id)
        {
            var itemToEdit = manager.GetItem(id);
            return View(itemToEdit);
        }

        // POST: Items/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
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

        // GET: Items/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Items/Delete/5
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
        [HttpGet]
        public PartialViewResult GetWorkplace(string id)
        {
            var workplace = manager.GetWorkplace(id);
            return PartialView("_WorkplaceDetail",workplace);
        }
    }
}
