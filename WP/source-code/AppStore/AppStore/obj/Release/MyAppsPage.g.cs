﻿

#pragma checksum "C:\Users\Srujan Jha\Documents\Visual Studio 2015\Projects\BuildmLearnStore\AppStore\AppStore\MyAppsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "25D58C33CFC9B1E07140C05B269789B1"
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
    partial class MyAppsPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 25 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ContainerContentChanging += this.GridMyApps_ContentChanging;
                 #line default
                 #line hidden
                #line 25 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.GridMyApps_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 28 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.StackPanel_Holding;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 33 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.UninstallButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 36 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.ShareButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 51 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Search_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 52 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Home_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 53 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Categories_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 60 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Settings_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 61 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Feedback_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 62 "..\..\MyAppsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.About_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

