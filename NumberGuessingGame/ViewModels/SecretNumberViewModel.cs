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
        //Current guess
        [Required(
            ErrorMessageResourceType = typeof(Resources.Strings),
            ErrorMessageResourceName = "RequiredError")]
        [RegularExpression("([0-9]+)",
             ErrorMessageResourceType = typeof(Resources.Strings),
            ErrorMessageResourceName = "RangeError")]
        [Range(1, 100, 
            ErrorMessageResourceType = typeof(Resources.Strings),
            ErrorMessageResourceName = "RangeError")]
        public int? Guess { get; set; }

        [ScaffoldColumn(false)]
        public SecretNumber SecretNumber { get; set; }

        //Returns the header text to display
        [ScaffoldColumn(false)]
        public string Header
        {
            get
            {
                if (SecretNumber.LastGuessedNumber.Outcome == Outcome.Right)
                    return Resources.Strings.CorrectGuess;
                else if (SecretNumber.Number != null)
                    return Resources.Strings.NoMoreGuesses;
                else
                    return String.Format(Resources.Strings.GuessNr, this.GuessNr());
            }
        }

        //Returns if the form should be DISPLAYED or not
        [ScaffoldColumn(false)]
        public bool DisplayForm
        {
            get
            {
                if (this.SecretNumber != null)
                    return this.SecretNumber.LastGuessedNumber.Outcome != Outcome.Right;
                return true;
            }
        }

        //Returns if the form should be DISABLED or ont
        [ScaffoldColumn(false)]
        public bool DisableForm
        {
            get
            {
                if (this.SecretNumber != null)
                    return this.SecretNumber.Number != null;
                return false;
            }
        }

        //Returns the messages that should be displayed
        public IEnumerable<string> Message()
        {
            var guess = SecretNumber.LastGuessedNumber.Number;
            var lastOutcome = SecretNumber.LastGuessedNumber.Outcome;
            var messages = new List<string>();

            if (lastOutcome == Outcome.Right)
            {
                messages.Add(String.Format(Resources.Strings.CorrectGuessMessage, this.GuessNr(0).ToLower()));
            }
            else
            {
                switch (lastOutcome)
                {
                    case Outcome.Low:
                        messages.Add(String.Format(Resources.Strings.LowGuess, guess));
                        break;

                    case Outcome.High:
                        messages.Add(String.Format(Resources.Strings.HighGuess, guess));
                        break;

                    case Outcome.OldGuess:
                        messages.Add(String.Format(Resources.Strings.OldGuess, guess));
                        break;
                }
                if (!SecretNumber.CanMakeGuess)
                {
                    messages.Add(Resources.Strings.NoMoreGuesses);
                    messages.Add(String.Format(Resources.Strings.SecretNumber, SecretNumber.Number));
                }
            }
            return messages;
        }

        //Returns number of guesses made or what guess that will be made
        //Cardinal to ordinal
        private string GuessNr(int start = 1)
        {
            switch (SecretNumber.Count + start)
            {
                case 1:
                    return Resources.Strings.First;
                case 2:
                    return Resources.Strings.Second;

                case 3:
                    return Resources.Strings.Third;

                case 4:
                    return Resources.Strings.Fourth;

                case 5:
                    return Resources.Strings.Fifth;

                case 6:
                    return Resources.Strings.Sixth;

                case 7:
                    return Resources.Strings.Seventh;

                default:
                    return "";
            }
        }
    }
}