using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BattleTech.Controllers
{
    public class HousesController : Controller
    {
        // GET: Houses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Houses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Houses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Houses/Create
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

        // GET: Houses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Houses/Edit/5
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

        // GET: Houses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Houses/Delete/5
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
