﻿#pragma checksum "..\..\Database.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50A5871723568E0C2A40F81DF50600D20DE94FBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FoxterServer_WPF;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace FoxterServer_WPF {
    
    
    /// <summary>
    /// Database
    /// </summary>
    public partial class Database : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insert_Button;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_Button;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl MainTab;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem UserTab;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserGrid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem FilmTab;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FilmGrid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem CinemaTab;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CinemaGrid;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem SessionTab;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Database.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SessionGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/FoxterServer WPF;component/database.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Database.xaml"
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
            
            #line 14 "..\..\Database.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Insert_Button = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Database.xaml"
            this.Insert_Button.Click += new System.Windows.RoutedEventHandler(this.Insert_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Delete_Button = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Database.xaml"
            this.Delete_Button.Click += new System.Windows.RoutedEventHandler(this.Delete_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Database.xaml"
            this.Save_Button.Click += new System.Windows.RoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MainTab = ((System.Windows.Controls.TabControl)(target));
            return;
            case 6:
            this.UserTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.UserGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\Database.xaml"
            this.UserGrid.Loaded += new System.Windows.RoutedEventHandler(this.UserGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FilmTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 9:
            this.FilmGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 53 "..\..\Database.xaml"
            this.FilmGrid.Loaded += new System.Windows.RoutedEventHandler(this.FilmGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CinemaTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 11:
            this.CinemaGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\Database.xaml"
            this.CinemaGrid.Loaded += new System.Windows.RoutedEventHandler(this.CinemaGrid_Loaded);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SessionTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 13:
            this.SessionGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 63 "..\..\Database.xaml"
            this.SessionGrid.Loaded += new System.Windows.RoutedEventHandler(this.SessionGrid_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

