﻿#pragma checksum "..\..\Volume_and_BalanceControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A63DAA1C6FA6F45B7DA5A7AEB940FA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
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
    /// Volume_and_BalanceControl
    /// </summary>
    public partial class Volume_and_BalanceControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MusicClassificationGui.Volume_and_BalanceControl UserControl;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Volume_and_Balance;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Vol_text2;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Vol_text1;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider LeftValumeSlider;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider RightVolumeSlider;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\Volume_and_BalanceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider MixerSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/MusicClassificationGui;component/volume_and_balancecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Volume_and_BalanceControl.xaml"
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
            this.UserControl = ((MusicClassificationGui.Volume_and_BalanceControl)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Volume_and_Balance = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Vol_text2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Vol_text1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.LeftValumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 117 "..\..\Volume_and_BalanceControl.xaml"
            this.LeftValumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.DockLeftSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RightVolumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 118 "..\..\Volume_and_BalanceControl.xaml"
            this.RightVolumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.DockRightSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MixerSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 119 "..\..\Volume_and_BalanceControl.xaml"
            this.MixerSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.MixerSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

