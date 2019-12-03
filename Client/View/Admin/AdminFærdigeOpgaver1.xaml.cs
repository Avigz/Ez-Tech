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
using Client.View.Hjælper;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View.Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminFærdigeOpgaver1 : Page
    {
        public AdminFærdigeOpgaver1()
        {
            this.InitializeComponent();
            ViewModel.ViewModel vm= new ViewModel.ViewModel();
            this.DataContext = vm;
        }

        private void HamburgerMenu_OnChecked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void AdminLogin_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void AdminAktuelleOpgaver_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminAktuelleOpgaver));
        }

        private void AdminHjælpere_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperPage));
        }

        private void AdminFærdigeOpgaver_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton3_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton5_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

       

        private void HamburgerButton_OnChecked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LV_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Lv_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
