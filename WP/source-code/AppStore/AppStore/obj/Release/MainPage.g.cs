﻿

#pragma checksum "C:\Users\Srujan Jha\Documents\Visual Studio 2015\Projects\BuildmLearnStore\AppStore\AppStore\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A820CCB681D8ACAC80B2534CE9C2140"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppStore
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 46 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ContainerContentChanging += this.GridFeaturedApps_ContentChanging;
                 #line default
                 #line hidden
                #line 46 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.GridFeaturedApps_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 49 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.StackPanel_Holding;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 54 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.InstallButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 57 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.ShareButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 27 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ContainerContentChanging += this.GridFeaturedCategories_ContentChanging;
                 #line default
                 #line hidden
                #line 27 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.GridFeaturedCategories_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 74 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Search_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 75 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.MyApps_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 76 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Categories_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 83 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Settings_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 84 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Feedback_Click;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 85 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.About_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

