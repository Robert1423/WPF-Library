﻿#pragma checksum "..\..\..\..\MVVM\View\TitleAddView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C558BE3030DD783874FDE51D16D27AC394D9FD6D117D6D072B49BC7F2B9A3573"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.MVVM.View;
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


namespace Library.MVVM.View {
    
    
    /// <summary>
    /// TitleAddView
    /// </summary>
    public partial class TitleAddView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authorBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantityBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ChooseDate;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTitleBtn;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\MVVM\View\TitleAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelTitleBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/mvvm/view/titleaddview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\TitleAddView.xaml"
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
            this.authorBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.titleBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.quantityBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\..\MVVM\View\TitleAddView.xaml"
            this.quantityBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.QuantityBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ChooseDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.typeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AddTitleBtn = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\MVVM\View\TitleAddView.xaml"
            this.AddTitleBtn.Click += new System.Windows.RoutedEventHandler(this.AddTitleBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelTitleBtn = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\MVVM\View\TitleAddView.xaml"
            this.CancelTitleBtn.Click += new System.Windows.RoutedEventHandler(this.CancelTitleBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
