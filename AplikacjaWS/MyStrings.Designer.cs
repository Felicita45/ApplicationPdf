﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikacjaWS {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MyStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MyStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AplikacjaWS.MyStrings", typeof(MyStrings).Assembly);
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
        ///   Looks up a localized string similar to Konto utworzone.
        /// </summary>
        internal static string AccCreation {
            get {
                return ResourceManager.GetString("AccCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Utworzone.
        /// </summary>
        internal static string Create {
            get {
                return ResourceManager.GetString("Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Błąd.
        /// </summary>
        internal static string ErrorTitle {
            get {
                return ResourceManager.GetString("ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aby zmiany zaczęły obowiązywać, musisz ponownie uruchomić program..
        /// </summary>
        internal static string ExitRequest {
            get {
                return ResourceManager.GetString("ExitRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wyjść.
        /// </summary>
        internal static string ExitTitle {
            get {
                return ResourceManager.GetString("ExitTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wpisz Login.
        /// </summary>
        internal static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Brak połączenia z bazą.
        /// </summary>
        internal static string NoConnection {
            get {
                return ResourceManager.GetString("NoConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Konto nie zostało utworzone.
        /// </summary>
        internal static string NotCreated {
            get {
                return ResourceManager.GetString("NotCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wpisz Hasło.
        /// </summary>
        internal static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login has already been registered.
        /// </summary>
        internal static string Registered {
            get {
                return ResourceManager.GetString("Registered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nieprawidłowy login lub hasło.
        /// </summary>
        internal static string Warning {
            get {
                return ResourceManager.GetString("Warning", resourceCulture);
            }
        }
    }
}