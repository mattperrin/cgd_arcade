﻿#pragma checksum "..\..\EntryDetailWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D836F9D23F449134B084CF37749F87F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
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


namespace CGDArcade_WPF {
    
    
    /// <summary>
    /// EntryDetailWindow
    /// </summary>
    public partial class EntryDetailWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement entityMediaElement;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement entityMedia1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement entityMedia2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement entityMedia3;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Title;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Author;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lbl_Description;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\EntryDetailWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_btn_GridLayout;
        
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
            System.Uri resourceLocater = new System.Uri("/CGDArcade_WPF;component/entrydetailwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EntryDetailWindow.xaml"
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
            this.entityMediaElement = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.entityMedia1 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.entityMedia2 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 4:
            this.entityMedia3 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 5:
            this.lbl_Title = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbl_Author = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbl_Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 18 "..\..\EntryDetailWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.img_btn_GridLayout = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\EntryDetailWindow.xaml"
            this.img_btn_GridLayout.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.img_btn_GridLayout_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

