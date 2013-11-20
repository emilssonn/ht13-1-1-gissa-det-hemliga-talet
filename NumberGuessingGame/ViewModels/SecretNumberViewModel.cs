using NumberGuessingGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumberGuessingGame.ViewModels
{
    public class SecretNumberViewModel
    {
        [Required(ErrorMessage = "En gissing måste anges.")]
        [Range(1,100, ErrorMessage = "Måste vara ett heltal mellan 1 och 100")]
        public int Number { get; set; }

        [ScaffoldColumn(false)]
        public SecretNumber SecretNumber { get; set; }

        [ScaffoldColumn(false)]
        public string Header
        {
            get
            {
                if (SecretNumber.LastGuessedNumber.Outcome == Outcome.Right)
                    return "Rätt gissat!";
                else if (SecretNumber.Number != null)
                    return "Inga fler gissningar!";
                else
                    return String.Format("{0} gissningen", this.GuessNr());
            }
        }
       
        public IEnumerable<string> Message()
        {  
            var guess = SecretNumber.LastGuessedNumber.Number;
            var lastOutcome = SecretNumber.LastGuessedNumber.Outcome;
            var messages = new List<string>();

            if (lastOutcome == Outcome.Right)
            {
                messages.Add(String.Format("Gratis du klarade det på {0} försöket.", this.GuessNr(0).ToLower()));
            }
            else
            {
                switch (lastOutcome)
                {
                    case Outcome.Low:
                        messages.Add(String.Format("{0} är för lågt.", guess));
                        break;

                    case Outcome.High:
                        messages.Add(String.Format("{0} är för högt.", guess));
                        break;

                    case Outcome.OldGuess:
                        messages.Add(String.Format("Du har redan gissat på talet {0}!", guess));
                        break;
                }
                if (!SecretNumber.CanMakeGuess)
                {
                    messages.Add("Inga mer gissningar");
                    messages.Add(String.Format("Det hemliga talet var {0}!", SecretNumber.Number));
                }
            }
            return messages;
        }

        private string GuessNr(int start = 1)
        {   
            switch (SecretNumber.Count + start)
            {
                case 1:
                    return "Första";
                case 2:
                    return "Andra";

                case 3:
                    return "Tredje";

                case 4:
                    return "Fjärde";

                case 5:
                    return "Femte";

                case 6:
                    return "Sjätte";

                case 7:
                    return "Sjunde";
                    
                default:
                    return "";
            }           
        }
    }
}