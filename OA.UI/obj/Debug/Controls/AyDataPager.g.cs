﻿#pragma checksum "..\..\..\Controls\AyDataPager.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B3099A6CFE4DA2887D8E5A8829784932C3AF4ABA6927F7D4233576FC115F572"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Ay.Framework.WPF.Controls;
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


namespace Ay.Framework.WPF.Controls {
    
    
    /// <summary>
    /// AyDataPager
    /// </summary>
    public partial class AyDataPager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyDataPager dp;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyComboBox cboPageSize;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyImageButton btnFirst;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyImageButton btnPrev;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPageIndex;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyImageButton btnNext;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyImageButton btnLast;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Controls\AyDataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ay.Framework.WPF.Controls.AyImageButton btnRefresh;
        
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
            System.Uri resourceLocater = new System.Uri("/OA.UI;component/controls/aydatapager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\AyDataPager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.dp = ((Ay.Framework.WPF.Controls.AyDataPager)(target));
            
            #line 9 "..\..\..\Controls\AyDataPager.xaml"
            this.dp.Loaded += new System.Windows.RoutedEventHandler(this.DataPager_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboPageSize = ((Ay.Framework.WPF.Controls.AyComboBox)(target));
            return;
            case 3:
            this.btnFirst = ((Ay.Framework.WPF.Controls.AyImageButton)(target));
            return;
            case 4:
            this.btnPrev = ((Ay.Framework.WPF.Controls.AyImageButton)(target));
            return;
            case 5:
            this.tbPageIndex = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\Controls\AyDataPager.xaml"
            this.tbPageIndex.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.tbPageIndex_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Controls\AyDataPager.xaml"
            this.tbPageIndex.LostFocus += new System.Windows.RoutedEventHandler(this.tbPageIndex_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnNext = ((Ay.Framework.WPF.Controls.AyImageButton)(target));
            return;
            case 7:
            this.btnLast = ((Ay.Framework.WPF.Controls.AyImageButton)(target));
            return;
            case 8:
            this.btnRefresh = ((Ay.Framework.WPF.Controls.AyImageButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

