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
                    Session[SessionLocation] = new SecretNumber();       
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Number")]SecretNumberViewModel sNViewModel)
        {
            Session.Timeout = 1; 
            sNViewModel.SecretNumber = this.SecretNumber;
            if (ModelState.IsValid)
            {           
                if (this.SecretNumber.CanMakeGuess)
                {
                    Outcome guess = this.SecretNumber.MakeGuess(sNViewModel.Number);
                    switch (guess)
                    {
                        case Outcome.Low:

                            break;
                        case Outcome.High:
                            break;
                        case Outcome.Right:
                            break;
                        case Outcome.NoMoreGuesses:
                            break;
                        case Outcome.OldGuess:
                            break;
                        default:
                            break;
                    }
                }
            }
            return View("Index", sNViewModel);
        }

    }
}
