﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmVinDecoderLib.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AmVinDecoderLib.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Unrecognized model year code..
        /// </summary>
        internal static string Error_BadModelYear {
            get {
                return ResourceManager.GetString("Error_BadModelYear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting a digit..
        /// </summary>
        internal static string Error_CharDigit {
            get {
                return ResourceManager.GetString("Error_CharDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting a letter..
        /// </summary>
        internal static string Error_CharLetter {
            get {
                return ResourceManager.GetString("Error_CharLetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No conversion implemented for these units..
        /// </summary>
        internal static string Error_ConversionNotImplemented {
            get {
                return ResourceManager.GetString("Error_ConversionNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting only digits..
        /// </summary>
        internal static string Error_OnlyDigits {
            get {
                return ResourceManager.GetString("Error_OnlyDigits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting only letters..
        /// </summary>
        internal static string Error_OnlyLetters {
            get {
                return ResourceManager.GetString("Error_OnlyLetters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting only letters and digits..
        /// </summary>
        internal static string Error_OnlyLettersAndDigits {
            get {
                return ResourceManager.GetString("Error_OnlyLettersAndDigits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1} speed automated manual.
        /// </summary>
        internal static string Transmission_AutomatedManualFormat {
            get {
                return ResourceManager.GetString("Transmission_AutomatedManualFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} speed auto.
        /// </summary>
        internal static string Transmission_AutomaticFormat {
            get {
                return ResourceManager.GetString("Transmission_AutomaticFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} speed manual.
        /// </summary>
        internal static string Transmission_ManualFormat {
            get {
                return ResourceManager.GetString("Transmission_ManualFormat", resourceCulture);
            }
        }
    }
}
