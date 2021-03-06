﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Client.View.Admin;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View.Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        public AdminPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (mySplitView.IsPaneOpen == false)
            {
                mySplitView.IsPaneOpen = true;
            }
            else if (mySplitView.IsPaneOpen == true)
            {
                mySplitView.IsPaneOpen = false;
            }


        }
        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminPage));
        }

        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminAktuelleOpgaver));
        }

        private void MenuButton4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminHjælpere));
        }

        private void MenuButton5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }

        private void OpretOpgave_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminOpretOpgave));
        }

        private void Logaf_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void AdminKunder_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminKunder));
        }
    }

    

   

}
