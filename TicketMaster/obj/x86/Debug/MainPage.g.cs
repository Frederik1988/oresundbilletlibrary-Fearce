﻿#pragma checksum "C:\Users\theke\source\repos\oresundbilletlibrary-Fearce\TicketMaster\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B40B37E5D797D1D28EFF615FEE445F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketMaster
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {
                    this.Main = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // MainPage.xaml line 19
                {
                    this.PrisLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 21
                {
                    this.TotalPrisLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 22
                {
                    this.Nummerplade = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Nummerplade).TextChanged += this.Nummerplade_OnTextChanged;
                }
                break;
            case 5: // MainPage.xaml line 23
                {
                    this.Køretøj = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.Køretøj).SelectionChanged += this.Køretøj_OnSelectionChanged;
                }
                break;
            case 6: // MainPage.xaml line 24
                {
                    this.DatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.DatePicker)this.DatePicker).DateChanged += this.DatePicker_OnDateChanged;
                }
                break;
            case 7: // MainPage.xaml line 25
                {
                    this.Brobizz = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Brobizz).Checked += this.Brobizz_OnChecked;
                }
                break;
            case 8: // MainPage.xaml line 26
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.AppBarButton_Click;
                }
                break;
            case 9: // MainPage.xaml line 28
                {
                    this.Bro = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.Bro).SelectionChanged += this.Bro_SelectionChanged;
                }
                break;
            case 10: // MainPage.xaml line 29
                {
                    this.Liste = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

