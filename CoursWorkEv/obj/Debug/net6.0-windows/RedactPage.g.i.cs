﻿#pragma checksum "..\..\..\RedactPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0019EC91F94421C276F73517BD34B668CE6C3B05"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoursWorkEv;
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


namespace CoursWorkEv {
    
    
    /// <summary>
    /// RedactPage
    /// </summary>
    public partial class RedactPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNameOfPizza;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDescriptionOfPizza;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPicture;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddLink;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPrice;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonRedact;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNext;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CoursWorkEv;V1.0.0.0;component/redactpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RedactPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextBoxNameOfPizza = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxDescriptionOfPizza = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxPicture = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ButtonAddLink = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\RedactPage.xaml"
            this.ButtonAddLink.Click += new System.Windows.RoutedEventHandler(this.ButtonAddLink_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBoxPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.RadioButtonRedact = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.RadioButtonDelete = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.RadioButtonAdd = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.ButtonNext = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\RedactPage.xaml"
            this.ButtonNext.Click += new System.Windows.RoutedEventHandler(this.ButtonNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

