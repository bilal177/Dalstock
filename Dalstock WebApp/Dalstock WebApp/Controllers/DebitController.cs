using BL;
using Dalstock_WebApp.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dalstock_WebApp.Controllers
{
    public class DebitController : Controller
    {
        ItemManagerService manager = new ItemManager();
        DebitViewModel model = new DebitViewModel();

        // GET: Debit
        public ActionResult Index()
        {
            TempData.Remove("debitListToAdd");
            var workplaces = manager.GetWorkplaces().ToList();
            var items = manager.GetItems().ToList();
            model.Workplaces = workplaces;
            model.Items = items;
            return View(model);
        }

        // GET: Debit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Debit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Debit/Create
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

        // GET: Debit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Debit/Edit/5
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

        // GET: Debit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Debit/Delete/5
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
        public PartialViewResult AddDebitItem(string id, int amount, string workplaceId)
        {
            var list = new List<Debit>();
            if (TempData["debitListToAdd"] != null)
            {
                list = TempData["debitListToAdd"] as List<Debit>;
            }
            Debit debit = new Debit()
            {
                DebitId = list.Count()+1,
                ItemId = id,
                Amount = amount,
                date = new DateTime(),
                WorkplaceId = workplaceId
            };
            list.Add(debit);
            TempData["debitListToAdd"] = list;
            return PartialView("_DebitItemsToUpdate", list);
        }
        //Gets only the temporary list with partial view
        [HttpGet]
        public PartialViewResult GetToAddDebitList()
        {
            var list = new List<Debit>();
            if (TempData["debitListToAdd"] != null)
            {
                list = TempData["debitListToAdd"] as List<Debit>;
            }
            TempData["debitListToAdd"] = list;
            return PartialView("_DebitItemsToUpdate", list);
        }
        //Makes the templist persistent
        [HttpPost]
        public ActionResult CreateDebitItems(FormCollection collection)
        {
            var list = new List<Debit>();
            if (TempData["debitListToAdd"] != null)
            {
                list = TempData["debitListToAdd"] as List<Debit>;
            }

            //Code to make the list persistent
            return RedirectToAction("Index");
        }
        //Deletes debit items from templist
        [HttpGet]
        public ActionResult DeleteFromTempList(int id)
        {
            var list = new List<Debit>();
            if (TempData["debitListToAdd"] != null)
            {
                list = TempData["debitListToAdd"] as List<Debit>;
            }
            list.RemoveAll(x => x.DebitId == id);
            //Code to make the list persistent
            return RedirectToAction("GetToAddDebitList");
        }
    }
}
