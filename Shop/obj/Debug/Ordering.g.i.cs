﻿#pragma checksum "..\..\Ordering.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "13D9FD59FA4D22E81F43C969B631A6C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Shop;
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


namespace Shop {
    
    
    /// <summary>
    /// Ordering
    /// </summary>
    public partial class Ordering : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Ordering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AllPrice;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Ordering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Order;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Ordering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrdList;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Ordering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIO;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Ordering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Ordering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Shop;component/ordering.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Ordering.xaml"
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
            this.AllPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Order = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.OrdList = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\Ordering.xaml"
            this.OrdList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrderList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.OK = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Ordering.xaml"
            this.OK.Click += new System.Windows.RoutedEventHandler(this.OK_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Ordering.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

