﻿#pragma checksum "..\..\..\DVDPlayer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA359DDA79D0D85AC37D44ADFEA7CBD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SampleApplication.Controls;
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
using WPFMediaKit.DirectShow.Controls;


namespace SampleApplication {
    
    
    /// <summary>
    /// Window3
    /// </summary>
    public partial class Window3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\DVDPlayer.xaml"
        internal System.Windows.Media.Animation.BeginStoryboard ShowAuxControls_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\DVDPlayer.xaml"
        internal System.Windows.Media.Animation.BeginStoryboard HideAuxControls_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\DVDPlayer.xaml"
        internal SampleApplication.Controls.FolderDialog folderDialog;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\DVDPlayer.xaml"
        internal WPFMediaKit.DirectShow.Controls.DvdPlayerElement dvdPlayer;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\DVDPlayer.xaml"
        internal System.Windows.Controls.Slider positionSlider;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\DVDPlayer.xaml"
        internal System.Windows.Controls.Viewbox viewbox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\DVDPlayer.xaml"
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/SampleApplication;component/dvdplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DVDPlayer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ShowAuxControls_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.HideAuxControls_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.folderDialog = ((SampleApplication.Controls.FolderDialog)(target));
            return;
            case 4:
            this.dvdPlayer = ((WPFMediaKit.DirectShow.Controls.DvdPlayerElement)(target));
            return;
            case 5:
            this.positionSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.viewbox = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 7:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
