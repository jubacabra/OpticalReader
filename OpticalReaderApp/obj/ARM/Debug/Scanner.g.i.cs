﻿#pragma checksum "C:\Users\Jubacabra\Desktop\Repositories\OpticalReaderLaptop\OpticalReaderApp\Scanner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DED4B7816BCBC5842A8D45E82C6B06F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace OpticalReaderApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel GuideStackPanel;
        
        internal System.Windows.Controls.StackPanel ResultStackPanel;
        
        internal System.Windows.Controls.Image ThumbnailImage;
        
        internal System.Windows.Controls.TextBlock TypeTextBlock;
        
        internal System.Windows.Controls.TextBlock DescriptionTextBlock;
        
        internal System.Windows.Controls.TextBlock RigtigText;
        
        internal System.Windows.Controls.CheckBox DebugCheckBox;
        
        internal System.Windows.Controls.TextBlock DebugTextBlock;
        
        internal System.Windows.Controls.Slider SizeSlider;
        
        internal System.Windows.Controls.TextBlock SizeTextBlock;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/OpticalReaderApp;component/Scanner.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.GuideStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("GuideStackPanel")));
            this.ResultStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ResultStackPanel")));
            this.ThumbnailImage = ((System.Windows.Controls.Image)(this.FindName("ThumbnailImage")));
            this.TypeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TypeTextBlock")));
            this.DescriptionTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("DescriptionTextBlock")));
            this.RigtigText = ((System.Windows.Controls.TextBlock)(this.FindName("RigtigText")));
            this.DebugCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("DebugCheckBox")));
            this.DebugTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("DebugTextBlock")));
            this.SizeSlider = ((System.Windows.Controls.Slider)(this.FindName("SizeSlider")));
            this.SizeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("SizeTextBlock")));
        }
    }
}

