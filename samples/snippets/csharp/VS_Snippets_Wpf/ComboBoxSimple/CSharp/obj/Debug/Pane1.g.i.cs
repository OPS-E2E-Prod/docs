﻿#pragma checksum "..\..\Pane1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D5EF9502C2732E5D0A311EF6DD29D4E7FAC5FD80B5929ED2F0563F35F131A0C8"
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


namespace ComboBoxSimple {
    
    
    /// <summary>
    /// Pane1
    /// </summary>
    public partial class Pane1 : System.Windows.Controls.Canvas, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbi1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbi2;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cbi3;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\Pane1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cv2;
        
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
            System.Uri resourceLocater = new System.Uri("/ComboBoxSimple;component/pane1.xaml", System.UriKind.Relative);
            
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
            this.cbi1 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 2:
            this.cbi2 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 3:
            this.cbi3 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.cb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 115 "..\..\Pane1.xaml"
            this.cb.DropDownOpened += new System.EventHandler(this.OnDropDownOpened);
            
            #line default
            #line hidden
            
            #line 116 "..\..\Pane1.xaml"
            this.cb.DropDownClosed += new System.EventHandler(this.OnDropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 130 "..\..\Pane1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cv2 = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

