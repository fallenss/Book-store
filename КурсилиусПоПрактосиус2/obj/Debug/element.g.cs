﻿#pragma checksum "..\..\element.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F230F9F907CEFE2C85EEC31AC441101B817D200D42C8A17A2CFDE61189EF5AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using КурсилиусПоПрактосиус2;


namespace КурсилиусПоПрактосиус2 {
    
    
    /// <summary>
    /// element
    /// </summary>
    public partial class element : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\element.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Gridetsky;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\element.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button smert;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\element.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button red;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\element.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
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
            System.Uri resourceLocater = new System.Uri("/КурсилиусПоПрактосиус2;component/element.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\element.xaml"
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
            this.Gridetsky = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.smert = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\element.xaml"
            this.smert.Click += new System.Windows.RoutedEventHandler(this.smert_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.red = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\element.xaml"
            this.red.Click += new System.Windows.RoutedEventHandler(this.red_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\element.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

