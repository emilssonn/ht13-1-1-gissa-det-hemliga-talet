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
        public string Message
        {
            get
            {
                var guess = SecretNumber.LastGuessedNumber.Number;
                switch (SecretNumber.LastGuessedNumber.Outcome)
                {          
                    case Outcome.Low:
                        return String.Format("{0} är för lågt.", guess);

                    case Outcome.High:
                        return String.Format("{0} är för högt.", guess);

                    case Outcome.Right:
                        return String.Format("Gratis du klarade det på {0} försöket.", this.GuessNr(0).ToLower());

                    case Outcome.NoMoreGuesses:
                        return "Inga mer gissningar";

                    case Outcome.OldGuess:
                        return String.Format("Du har redan gissat på talet {0}!", guess);

                    default:
                        return "";
                }
            }
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
                    return "Inga fler gissningar!";
            }
            
        }

       

    }
}