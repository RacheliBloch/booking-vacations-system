﻿#pragma checksum "..\..\UpdateHostingUnit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB1C905EA51B7563926495C93B623A69A6106BB53F8E6BD6F1A288D4BECBC1B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// UpdateHostingUnit
    /// </summary>
    public partial class UpdateHostingUnit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel hostingUnitDetailsStack;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPriceForAdult;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPriceForChild;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AreaComboBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbArea;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\UpdateHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/updatehostingunit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdateHostingUnit.xaml"
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
            this.hostingUnitDetailsStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.cboxName = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\UpdateHostingUnit.xaml"
            this.cboxName.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboxName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbPriceForAdult = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbPriceForChild = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\UpdateHostingUnit.xaml"
            this.txbPriceForChild.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbPriceForChild_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AreaComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\UpdateHostingUnit.xaml"
            this.AreaComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AreaComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbArea = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\UpdateHostingUnit.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
