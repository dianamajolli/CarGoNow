﻿#pragma checksum "..\..\..\Views\UCReservation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D177ED210C2122FF382EB9863F8C56F684CB413E9F4917AD854E8995E47CE202"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarGoNowApp.Views;
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


namespace CarGoNowApp.Views {
    
    
    /// <summary>
    /// UCReservation
    /// </summary>
    public partial class UCReservation : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker pickerCheckin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker pickerCheckout;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCarId;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerId;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeId;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDlt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMakeRes;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRentalID;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\UCReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/CarGoNowApp;component/views/ucreservation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UCReservation.xaml"
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
            this.pickerCheckin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.pickerCheckout = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.txtCarId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCustomerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtEmployeeId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Views\UCReservation.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDlt = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Views\UCReservation.xaml"
            this.btnDlt.Click += new System.Windows.RoutedEventHandler(this.btnDlt_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnMakeRes = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\UCReservation.xaml"
            this.btnMakeRes.Click += new System.Windows.RoutedEventHandler(this.btnMakeRes_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtRentalID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 51 "..\..\..\Views\UCReservation.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

