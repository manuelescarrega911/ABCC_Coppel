﻿#pragma checksum "..\..\Depa-Clas-Fam.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F472B6108BEEFC6D081E7D336ED322C3ECD1B700E3FA21929550112BD95CCE09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ABCC_Articulos;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ABCC_Articulos {
    
    
    /// <summary>
    /// Depa_Clas_Fam
    /// </summary>
    public partial class Depa_Clas_Fam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Depa-Clas-Fam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Tabla_Departamento;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Depa-Clas-Fam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Tabla_InfoSku_Copy;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Depa-Clas-Fam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Tabla_Clase;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Depa-Clas-Fam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Tabla_Familia;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Depa-Clas-Fam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salir_Menu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ABCC_Articulos;component/depa-clas-fam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Depa-Clas-Fam.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\Depa-Clas-Fam.xaml"
            ((ABCC_Articulos.Depa_Clas_Fam)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tabla_Departamento = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.Tabla_InfoSku_Copy = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\Depa-Clas-Fam.xaml"
            this.Tabla_InfoSku_Copy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Tabla_InfoSku_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Tabla_Clase = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.Tabla_Familia = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.Salir_Menu = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\Depa-Clas-Fam.xaml"
            this.Salir_Menu.Click += new System.Windows.RoutedEventHandler(this.Salir_Menu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

