﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumberGuessingGame.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NumberGuessingGame.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rätt gissat!.
        /// </summary>
        internal static string CorrectGuess {
            get {
                return ResourceManager.GetString("CorrectGuess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Grattis du klarade det på {0} försöket..
        /// </summary>
        internal static string CorrectGuessMessage {
            get {
                return ResourceManager.GetString("CorrectGuessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Femte.
        /// </summary>
        internal static string Fifth {
            get {
                return ResourceManager.GetString("Fifth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Första.
        /// </summary>
        internal static string First {
            get {
                return ResourceManager.GetString("First", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fjärde.
        /// </summary>
        internal static string Fourth {
            get {
                return ResourceManager.GetString("Fourth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} gissningen.
        /// </summary>
        internal static string GuessNr {
            get {
                return ResourceManager.GetString("GuessNr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} är för högt..
        /// </summary>
        internal static string HighGuess {
            get {
                return ResourceManager.GetString("HighGuess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} är för lågt..
        /// </summary>
        internal static string LowGuess {
            get {
                return ResourceManager.GetString("LowGuess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inga fler gissningar!.
        /// </summary>
        internal static string NoMoreGuesses {
            get {
                return ResourceManager.GetString("NoMoreGuesses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Du har redan gissat på talet {0}!.
        /// </summary>
        internal static string OldGuess {
            get {
                return ResourceManager.GetString("OldGuess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Måste vara ett heltal mellan 1 och 100..
        /// </summary>
        internal static string RangeError {
            get {
                return ResourceManager.GetString("RangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to En gissing måste anges..
        /// </summary>
        internal static string RequiredError {
            get {
                return ResourceManager.GetString("RequiredError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Andra.
        /// </summary>
        internal static string Second {
            get {
                return ResourceManager.GetString("Second", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Det hemliga talet var {0}!.
        /// </summary>
        internal static string SecretNumber {
            get {
                return ResourceManager.GetString("SecretNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sjunde.
        /// </summary>
        internal static string Seventh {
            get {
                return ResourceManager.GetString("Seventh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sjätte.
        /// </summary>
        internal static string Sixth {
            get {
                return ResourceManager.GetString("Sixth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tredje.
        /// </summary>
        internal static string Third {
            get {
                return ResourceManager.GetString("Third", resourceCulture);
            }
        }
    }
}