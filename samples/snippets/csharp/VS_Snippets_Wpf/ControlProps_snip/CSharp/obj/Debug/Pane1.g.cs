﻿#pragma checksum "..\..\Pane1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57F97C4EB7C830AE16020EF5B1F0AB05B8701774169D2365D76246914AFE2E91"
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


namespace ControlProps {
    
    
    /// <summary>
    /// Pane1
    /// </summary>
    public partial class Pane1 : System.Windows.Controls.StackPanel, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn9;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn10;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn11;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn12;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn13;
        
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
            System.Uri resourceLocater = new System.Uri("/ControlProps;component/pane1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pane1.xaml"
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
            this.btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Pane1.xaml"
            this.btn.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ChangeBackground);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Pane1.xaml"
            this.btn1.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ChangeForeground);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn9 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Pane1.xaml"
            this.btn9.Click += new System.Windows.RoutedEventHandler(this.ChangeBorderThickness);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn10 = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Pane1.xaml"
            this.btn10.Click += new System.Windows.RoutedEventHandler(this.ChangeFontStretch);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn11 = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\Pane1.xaml"
            this.btn11.Click += new System.Windows.RoutedEventHandler(this.ChangePadding);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn12 = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btn13 = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\Pane1.xaml"
            this.btn13.Click += new System.Windows.RoutedEventHandler(this.IsTabStop);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

