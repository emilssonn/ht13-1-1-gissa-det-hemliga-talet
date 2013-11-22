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

        //Get SecretNumber from session or create a new.
        //Throws Exception if session expired and Request method is post
        private SecretNumber SecretNumber
        {
            get
            {
                if (Request.HttpMethod.ToLower() == "post")
                {
                    if (Session[SessionLocation] == null || Session.IsNewSession)
                        throw new Exception();       
                }
                if (Session[SessionLocation] == null)
                {
                    Session[SessionLocation] = new SecretNumber();
                }
                return (SecretNumber)Session[SessionLocation];
            }
        }

        // GET: /SecretNumber/
        public ActionResult Index()
        {
            var sNViewModel = new SecretNumberViewModel();
            sNViewModel.SecretNumber = this.SecretNumber;
            return View("Index", sNViewModel);
        }

        // GET: /SecretNumber/New
        //Init a new game, redirect to Index
        public ActionResult New()
        {
            this.SecretNumber.Initialize();
            return RedirectToAction("Index");
        }

        // POST: /SecretNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Guess")]SecretNumberViewModel sNViewModel)
        {
            try
            {
                sNViewModel.SecretNumber = this.SecretNumber;
                if (ModelState.IsValid)
                {
                    this.SecretNumber.MakeGuess(sNViewModel.Guess.Value);
                }
                return View("Index", sNViewModel);
            }
            //Session Expired
            catch (Exception)
            {
                return View("GameEnded");
            }
        }
    }
}
