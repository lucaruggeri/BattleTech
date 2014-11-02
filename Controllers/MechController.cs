using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using BattleTech.Models;
using BattleTech.BTCode;
using BattleTech.BTServicesReference;
using System.Web.Services;

namespace BattleTech.Controllers
{
    public class MechController : Controller
    {

        // context
        BattleTechEntities myContext = new BattleTechEntities();

        public ActionResult MechsListGeneralView()
        {

            // model
            var myModel = myContext.viewMechs.ToList();

            return View(myModel);
        }

        public ActionResult MechsList()
        {

            // model
            var myModel = myContext.BattleMechs.ToList();

            //// list format 
            //string formatValue;
            //if (RouteData.Values["id"] == null)
            //{
            //    formatValue = "XML";
            //}
            //else {
            //    formatValue = RouteData.Values["id"].ToString();
            //}

            //// passing data
            //ViewBag.ssList = ss;
            //ViewBag.formatValue = formatValue;

            return View(myModel);
        }

        // GET: TEST_TO_DELETE_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattleMech battleMech = myContext.BattleMechs.Find(id);
            if (battleMech == null)
            {
                return HttpNotFound();
            }
            return View(battleMech);
        }

        // POST: TEST_TO_DELETE_/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,PicturePath,ManufacturerID,ProductionYear,ClassID")] BattleMech battleMech)
        {
            if (ModelState.IsValid)
            {
                myContext.Entry(battleMech).State = EntityState.Modified;
                myContext.SaveChanges();
                return RedirectToAction("MechsList");
            }
            return View(battleMech);
        }


        
        // GET: MechsList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TEST_TO_DELETE_/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,PicturePath,ManufacturerID,ProductionYear,ClassID")] BattleMech battleMech)
        {
            if (ModelState.IsValid)
            {
                myContext.BattleMechs.Add(battleMech);
                myContext.SaveChanges();
                return RedirectToAction("MechsList");
            }

            return View(battleMech);
        }

        // GET: MechsList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattleMech battleMech = myContext.BattleMechs.Find(id);
            if (battleMech == null)
            {
                return HttpNotFound();
            }
            return View(battleMech);
        }

        // POST: MechsList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BattleMech battleMech = myContext.BattleMechs.Find(id);
            myContext.BattleMechs.Remove(battleMech);
            myContext.SaveChanges();
            return RedirectToAction("MechsList");
        }

    
        // GET: MechsList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BattleMech battleMech = myContext.BattleMechs.Find(id);
            if (battleMech == null)
            {
                return HttpNotFound();
            }
            return View(battleMech);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                myContext.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}