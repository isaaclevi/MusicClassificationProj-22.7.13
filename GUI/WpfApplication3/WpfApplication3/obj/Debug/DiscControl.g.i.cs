﻿#pragma checksum "..\..\DiscControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "513AA18BC683BD4A4507F87CC2E71A44"
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


namespace MusicClassificationGui {
    
    
    /// <summary>
    /// DickControl
    /// </summary>
    public partial class DickControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MusicClassificationGui.DickControl DiscPanel;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard PlaySong_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanel;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Buttons;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel InnerButtons;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button play_button;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CUT_button;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\DiscControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Disc;
        
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
            System.Uri resourceLocater = new System.Uri("/MusicClassificationGui;component/disccontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DiscControl.xaml"
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
            this.DiscPanel = ((MusicClassificationGui.DickControl)(target));
            return;
            case 2:
            this.PlaySong_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.dockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.Buttons = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.InnerButtons = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 6:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\DiscControl.xaml"
            this.PauseButton.Click += new System.Windows.RoutedEventHandler(this.PauseButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.play_button = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\DiscControl.xaml"
            this.play_button.Click += new System.Windows.RoutedEventHandler(this.PlayButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CUT_button = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Disc = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

