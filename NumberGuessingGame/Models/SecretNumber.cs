using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGuessingGame.Models
{
    public class SecretNumber
    {
        private List<GuessedNumber> _guessedNumbers;

        private GuessedNumber _lastGuessedNumber;

        private int? _number;

        public const int MaxNumberOfGuesses = 7;

        public bool CanMakeGuess 
        {
            get
            {
                return this.Count < MaxNumberOfGuesses && this._lastGuessedNumber.Outcome != Outcome.Right;
            }
        }

        public int Count 
        {
            get
            {
                return this._guessedNumbers.Count();
            }
        }

        public IList<GuessedNumber> GuessedNumbers 
        {
            get
            {
                return this._guessedNumbers.AsReadOnly();
            }
        }

        public GuessedNumber LastGuessedNumber 
        {
            get
            {
                return this._lastGuessedNumber;
            }
        }

        public int? Number
        {
            get
            {
                return this.CanMakeGuess ? null : this._number;
            }
            private set
            {
                this._number = value;
            }
        }

        public void Initialize()
        {
            this._guessedNumbers.Clear();
            this._lastGuessedNumber.Number = null;
            this._lastGuessedNumber.Outcome = Outcome.Indefinite;
            this.Number = new Random().Next(1, 101);
        }

        public Outcome MakeGuess(int guess)
        {
            if (guess < 1 || guess > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (!this.CanMakeGuess)
            {
                return Outcome.NoMoreGuesses;
            }

            this._lastGuessedNumber = new GuessedNumber
            {
                Number = guess
            };

            if (this._guessedNumbers.Any(n => n.Number == guess))
            {
                this._lastGuessedNumber.Outcome = Outcome.OldGuess;
                return LastGuessedNumber.Outcome;
            }
            else if (guess > this._number)
            {
                this._lastGuessedNumber.Outcome = Outcome.High;
            }
            else if (guess < this._number)
            {
                this._lastGuessedNumber.Outcome = Outcome.Low;
            }
            else if (guess == this._number)
            {
                this._lastGuessedNumber.Outcome = Outcome.Right;
            }
            this._guessedNumbers.Add(this.LastGuessedNumber);
            return LastGuessedNumber.Outcome;
        }

        public SecretNumber()
        {
            this._guessedNumbers = new List<GuessedNumber>(MaxNumberOfGuesses);
            this.Initialize();
        }
    }
}