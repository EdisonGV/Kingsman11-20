﻿#pragma checksum "..\..\..\Windows\AddService.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCDADA8F1416FFAAC125645A4995D3A789BBF9DCF9BB2EBB5EEB61CD82E4DFB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kingsman20.Windows;
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


namespace Kingsman20.Windows {
    
    
    /// <summary>
    /// AddServiceWindow
    /// </summary>
    public partial class AddServiceWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgImageService;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChooseImage;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNameService;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbDiscService;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPriceService;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbTypeService;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Windows\AddService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddService;
        
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
            System.Uri resourceLocater = new System.Uri("/Kingsman20;component/windows/addservice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddService.xaml"
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
            this.ImgImageService = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.BtnChooseImage = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\AddService.xaml"
            this.BtnChooseImage.Click += new System.Windows.RoutedEventHandler(this.BtnChooseImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbNameService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbDiscService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbPriceService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CmbTypeService = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtnAddService = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Windows\AddService.xaml"
            this.BtnAddService.Click += new System.Windows.RoutedEventHandler(this.BtnAddService_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

