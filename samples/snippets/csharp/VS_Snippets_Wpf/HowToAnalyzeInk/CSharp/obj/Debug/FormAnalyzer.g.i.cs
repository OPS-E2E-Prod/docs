﻿#pragma checksum "..\..\FormAnalyzer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "762B37010CE76AAD8243443D46731AE7F010B48B5ECF11B336FDB4BA87BBF3B2"
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




/// <summary>
/// FormAnalyzer
/// </summary>
public partial class FormAnalyzer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 9 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.InkCanvas xaml_writingCanvas;
    
    #line default
    #line hidden
    
    
    #line 48 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock xaml_blockTitle;
    
    #line default
    #line hidden
    
    
    #line 51 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock xaml_blockDirector;
    
    #line default
    #line hidden
    
    
    #line 54 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock xaml_blockStarring;
    
    #line default
    #line hidden
    
    
    #line 57 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock xaml_blockRating;
    
    #line default
    #line hidden
    
    
    #line 60 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock xaml_blockYear;
    
    #line default
    #line hidden
    
    
    #line 63 "..\..\FormAnalyzer.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock xaml_blockGenre;
    
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
        System.Uri resourceLocater = new System.Uri("/IADemo;component/formanalyzer.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\FormAnalyzer.xaml"
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
        this.xaml_writingCanvas = ((System.Windows.Controls.InkCanvas)(target));
        
        #line 10 "..\..\FormAnalyzer.xaml"
        this.xaml_writingCanvas.StrokeCollected += new System.Windows.Controls.InkCanvasStrokeCollectedEventHandler(this.RestartAnalysis);
        
        #line default
        #line hidden
        return;
            case 2:
        this.xaml_blockTitle = ((System.Windows.Controls.TextBlock)(target));
        return;
            case 3:
        this.xaml_blockDirector = ((System.Windows.Controls.TextBlock)(target));
        return;
            case 4:
        this.xaml_blockStarring = ((System.Windows.Controls.TextBlock)(target));
        return;
            case 5:
        this.xaml_blockRating = ((System.Windows.Controls.TextBlock)(target));
        return;
            case 6:
        this.xaml_blockYear = ((System.Windows.Controls.TextBlock)(target));
        return;
            case 7:
        this.xaml_blockGenre = ((System.Windows.Controls.TextBlock)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

