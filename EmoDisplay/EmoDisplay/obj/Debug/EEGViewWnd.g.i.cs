﻿#pragma checksum "..\..\EEGViewWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "92A8DC5E3FDC5442ED3A6AD1864DC4EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using EmoDisplay;
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


namespace EmoDisplay {
    
    
    /// <summary>
    /// EEGViewWnd
    /// </summary>
    public partial class EEGViewWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\EEGViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EmoDisplay.EEGView SrcView;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\EEGViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveDataBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\EEGViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SimulusCodeBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\EEGViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SourceTimeBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\EEGViewWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tag;
        
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
            System.Uri resourceLocater = new System.Uri("/EmoDisplay;component/eegviewwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EEGViewWnd.xaml"
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
            
            #line 5 "..\..\EEGViewWnd.xaml"
            ((EmoDisplay.EEGViewWnd)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 5 "..\..\EEGViewWnd.xaml"
            ((EmoDisplay.EEGViewWnd)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SrcView = ((EmoDisplay.EEGView)(target));
            return;
            case 3:
            this.SaveDataBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\EEGViewWnd.xaml"
            this.SaveDataBtn.Click += new System.Windows.RoutedEventHandler(this.SaveDataBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SimulusCodeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SourceTimeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Tag = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\EEGViewWnd.xaml"
            this.Tag.Click += new System.Windows.RoutedEventHandler(this.Tag_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

