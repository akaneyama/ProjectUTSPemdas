﻿#pragma checksum "..\..\..\Produk.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F82B2D32C4721E5AAF5489BC545C229F6A94782C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using projectutstoko;


namespace projectutstoko {
    
    
    /// <summary>
    /// Produk
    /// </summary>
    public partial class Produk : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridProduk;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdProduk;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNamaProduk;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtJumlahProduk;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHargaProduk;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDeskripsiProduk;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/projectutstoko;component/produk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Produk.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DataGridProduk = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\..\Produk.xaml"
            this.DataGridProduk.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridProduk_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtIdProduk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNamaProduk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtJumlahProduk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtHargaProduk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDeskripsiProduk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 57 "..\..\..\Produk.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TambahProduk_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 59 "..\..\..\Produk.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateProduk_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 61 "..\..\..\Produk.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HapusProduk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

