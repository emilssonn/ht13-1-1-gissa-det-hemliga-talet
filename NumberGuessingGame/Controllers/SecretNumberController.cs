using NumberGuessingGame.Models;
using NumberGuessingGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberGuessingGame.Controllers
{
    public class SecretNumberController : Controller
    {
        private static string SessionLocation = "SecretNumber";

        private SecretNumber SecretNumber
        {
            get
            {
                if (Session[SessionLocation] == null)
                {
                    Session.Timeout = 1; 
                    Session[SessionLocation] = new SecretNumber();
                }
                return (SecretNumber)Session[SessionLocation];
            }
        }

        //
        // GET: /SecretNumber/

        public ActionResult Index()
        {
            var sNViewModel = new SecretNumberViewModel();
            sNViewModel.SecretNumber = this.SecretNumber;
            return View("Index", sNViewModel);
        }

        public ActionResult New()
        {
            this.SecretNumber.Initialize();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Number")]SecretNumberViewModel sNViewModel)
        {
            if (Session[SessionLocation] == null)
            {
                return View("GameEnded");
            }
            sNViewModel.SecretNumber = this.SecretNumber;
            if (ModelState.IsValid)
            {           
                this.SecretNumber.MakeGuess(sNViewModel.Number);
            }
            return View("Index", sNViewModel);
        }
    }
}
