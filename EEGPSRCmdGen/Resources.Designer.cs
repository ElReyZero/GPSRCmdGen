﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoboCup.AtHome.EEGPSRCmdGen {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoboCup.AtHome.EEGPSRCmdGen.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a ; grammar name Cat1 - Advanced Manipulation
        ///; grammar tier High
        ///
        ///$Main     = $advman
        ///
        ///##############################################################################
        ///#
        ///# Serving breakfast
        ///#
        ///##############################################################################
        ///
        ///$advman   = $polite bring me something for breakfast; Up to the team to solve
        ///$advman   = $polite serve the breakfast; Up to the team how to solve
        ///$advman   = $polite bring me some $cereal, $fuit and $drink in a tray
        ///
        ///
        ///######## [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string EEGPSR_Category1 {
            get {
                return ResourceManager.GetString("EEGPSR_Category1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ; grammar name Cat2 - Advanced Object Recognition
        ///; grammar tier High
        ///
        ///$Main = $advor
        ///
        ///##############################################################################
        ///#
        ///# Bring from description
        ///#
        ///##############################################################################
        ///$advor	= $polite bring me the $bwhat from the {placement 1}.
        ///$advor	= $polite take the $bwhat from the {placement 1} to the {placement 2}.
        ///$advor	= $polite bring me the {category} at the $rpos {placement 1}.
        ///$advor	= Take the [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string EEGPSR_Category2 {
            get {
                return ResourceManager.GetString("EEGPSR_Category2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ; grammar name Cat3 - HRI and Incomplete Commands
        ///; grammar tier High
        ///
        ///$Main     = $polite $command
        ///
        ///##############################################################################
        ///#
        ///# Complex commands
        ///#
        ///##############################################################################
        ///$command  = $followob
        ///$command  = $guideob
        ///$command  = $findorob
        ///$command  = $findmpob and $guidem
        ///$command  = $findfpob and $guidef
        ///
        ///$command  = $takeob and ($place | $deliver)
        ///$command  = $take and ($placeob | $ [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string EEGPSR_Category3 {
            get {
                return ResourceManager.GetString("EEGPSR_Category3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ; grammar name Cat4 - Memory and Awareness
        ///; grammar tier High
        ///
        ///$Main = $disclaimer
        ///
        ///
        ///##############################################################################
        ///#
        ///# Polite
        ///#
        ///##############################################################################
        ///$polite = $disclaimer 
        ///$polite = $disclaimer Please
        ///$polite = $disclaimer Could you
        ///$polite = $disclaimer Robot please
        ///$polite = $disclaimer Could you please
        ///
        ///##############################################################################
        /// </summary>
        internal static string EEGPSR_Category4 {
            get {
                return ResourceManager.GetString("EEGPSR_Category4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ; grammar name Cat5 - People Recognition and Navigation
        ///; grammar tier High
        /// 
        ///$Main = $advprn
        ///
        ///##############################################################################
        ///#
        ///# Greet person matching description
        ///#
        ///##############################################################################
        ///$advprn	= $polite greet the $gwho
        ///
        ///$gwho	= $person in the $room
        ///
        ///##############################################################################
        ///#
        ///# Bring to person matching description
        ///#
        ///############## [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string EEGPSR_Category5 {
            get {
                return ResourceManager.GetString("EEGPSR_Category5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ; grammar name Cat6 - Simple Tasks
        ///; grammar tier Moderate
        ///
        ///$Main     = $polite $complex.
        ///
        ///
        ///##############################################################################
        ///#
        ///# Complex commands
        ///#
        ///##############################################################################
        ///$complex  = $triple
        ///$complex  = $single, $single, and $single
        ///$complex  = $doublel, and $single
        ///$complex  = $single, $doubler
        ///
        ///##############################################################################
        ///#
        ///# Triple task [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string EEGPSR_Category6 {
            get {
                return ResourceManager.GetString("EEGPSR_Category6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a /*****************************************************************************
        ///*
        ///* FORMAT
        ///*
        ///******************************************************************************
        ///*
        ///* ROOT
        ///* The root rule S of the grammar is the $Main Non-Terminal. In order for the
        ///* grammar to be valid, it must contain at least one $Main rule.
        ///*
        ///* Non-Terminal identifiers
        ///* A valid Non-Terminal identifier is a sequence of one or more letters,
        ///* digits, or underscore characters (_). Spaces, punctuation marks, and symbols [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string FormatSpecification {
            get {
                return ResourceManager.GetString("FormatSpecification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ##############################################################################
        ///#
        ///# ${GrammarName} Grammar
        ///# 
        ///# Author:  Mauricio Matamoros
        ///# Date:    June 2016
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