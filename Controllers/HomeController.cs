using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BattleTech.Models;
using BattleTech.BTCode;
using BattleTech.BTServicesReference;
using System.Web.Services;

namespace BattleTech.Controllers
{
    public class HomeController : Controller
    {
        // context
        BattleTechEntities myContext = new BattleTechEntities();

        // HOME
        public ActionResult BTHome()
        {
            return View();
        }

        // lista HOUSES
        public ActionResult Houses()
        {
            var hs = myContext.viewHouses.ToList();

            ViewBag.hsList = hs;

            return View();
        }

        // lista SUCCESSOR STATES
        public ActionResult SuccessorStates()
        {
            var ss = myContext.SuccessorStates.ToList();

            ViewBag.ssList = ss;

            return View();
        }

        // ATTACK SIMULATION
        public ActionResult AttackSimulation()
        {
            return View();
        }

        // CALCULATE ATTACK
        [HttpPost]
        public ActionResult CalculateAttack(FormCollection form)
        {
            int risultato = 0;
            int attackerAttack = Convert.ToInt32(form["Attack"]);
            int defenderDefence = Convert.ToInt32(form["Defence"]);

            // consuming web service
            BTServicesReference.BTWarClient myService = new BTWarClient();
            risultato = myService.Attack(attackerAttack, defenderDefence);

            return Content("Damage: " + risultato.ToString());
        }


        // --------------------------------------------------------------- OLD
        // --------------------------------------------------------------- OLD
        // --------------------------------------------------------------- OLD
        // --------------------------------------------------------------- OLD
        // --------------------------------------------------------------- OLD
        // --------------------------------------------------------------- OLD
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}