﻿#pragma checksum "..\..\..\View\CardItemExhibition.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D9A6BD3ACAE901E057B075A10400380E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CP_WPF.View;
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


namespace CP_WPF.View {
    
    
    /// <summary>
    /// CardItemExhibition
    /// </summary>
    public partial class CardItemExhibition : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MainImageExhibition;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AddFavOffExhibition;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AddFavImageFull;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AddFavOnExhibition;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AddFavImage;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EventNameExhibition;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlaceExhibition;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimetableExhibition;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BtnMoreDetails;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\View\CardItemExhibition.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Details;
        
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
            System.Uri resourceLocater = new System.Uri("/CP_WPF;component/view/carditemexhibition.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CardItemExhibition.xaml"
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
            this.MainImageExhibition = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.AddFavOffExhibition = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            
            #line 39 "..\..\..\View\CardItemExhibition.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteToFavoriteExhibition_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddFavImageFull = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.AddFavOnExhibition = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            
            #line 62 "..\..\..\View\CardItemExhibition.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToFavoriteExhibition_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddFavImage = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.EventNameExhibition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.PlaceExhibition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TimetableExhibition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.BtnMoreDetails = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            this.Details = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\View\CardItemExhibition.xaml"
            this.Details.Click += new System.Windows.RoutedEventHandler(this.DetailsExhibition_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

