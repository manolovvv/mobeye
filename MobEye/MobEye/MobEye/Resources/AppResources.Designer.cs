﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobEye.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MobEye.Resources.AppResources", typeof(AppResources).Assembly);
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
        ///   Looks up a localized string similar to Forgot Password?.
        /// </summary>
        internal static string ForgotPasswordText {
            get {
                return ResourceManager.GetString("ForgotPasswordText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login.
        /// </summary>
        internal static string LoginButton {
            get {
                return ResourceManager.GetString("LoginButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login With SMS Code.
        /// </summary>
        internal static string LoginCodeButton {
            get {
                return ResourceManager.GetString("LoginCodeButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I Have an Account.
        /// </summary>
        internal static string LoginMobeyeButton {
            get {
                return ResourceManager.GetString("LoginMobeyeButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login with your Mobeye account.
        /// </summary>
        internal static string LoginMobeyeTitle {
            get {
                return ResourceManager.GetString("LoginMobeyeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        internal static string PasswordPlaceholder {
            get {
                return ResourceManager.GetString("PasswordPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome To Mobeye.
        /// </summary>
        internal static string StartPageTitle {
            get {
                return ResourceManager.GetString("StartPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username.
        /// </summary>
        internal static string UsernamePlaceholder {
            get {
                return ResourceManager.GetString("UsernamePlaceholder", resourceCulture);
            }
        }
    }
}