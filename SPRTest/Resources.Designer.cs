﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoboCup.AtHome.SPRTest {
    using System;
	using RoboCup.AtHome.CommandGenerator;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoboCup.AtHome.SPRTest.Resources", typeof(Resources).Assembly);
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
        
        internal static string ArenaQuestions {
            get {
                return ResourceManager.GetString("ArenaQuestions", resourceCulture);
            }
        }
        
        internal static string CrowdQuestions {
            get {
                return ResourceManager.GetString("CrowdQuestions", resourceCulture);
            }
        }
        
        internal static string ObjectQuestions {
            get {
                return ResourceManager.GetString("ObjectQuestions", resourceCulture);
            }
        }
        
        internal static string PredefinedQuestions {
            get {
                return ResourceManager.GetString("PredefinedQuestions", resourceCulture);
            }
        }
        
        internal static string FormatSpecification {
            get {
                return ResourceManager.GetString("FormatSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ##############################################################################
        ///#
        ///# ${GrammarName} Grammar
        ///# 
        ///# Author:  Mauricio Matamoros
        ///# Date:    March 2015
        ///#
        ///# IMPORTANT: 
        ///# Since this document declares a grammar for generating sentences,
        ///# NO RECURSIVE rules must be used.
        ///# 
        ///##############################################################################
        ///.
        /// </summary>
        internal static string GrammarHeader {
            get {
                return ResourceManager.GetString("GrammarHeader", resourceCulture);
            }
        }
    }
}
