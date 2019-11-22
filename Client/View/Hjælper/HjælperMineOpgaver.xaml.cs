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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View.Hjælper
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HjælperMineOpgaver : Page
    {
        public HjælperMineOpgaver()
        {
            this.InitializeComponent();
        }

       

        private void MenuButton3_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void MenuButton4_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMineOpgaver));
        }

        private void MenuButton5_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperLedigeOpgaver));
        }

        private void TextBlock_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperLedigeOpgaver));
        }

        private void MenuButton6_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperFærdigeOpgaver));
        }

        private void MenuButton7_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMinProfil));
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

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMineOpgaver));
        }

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperLedigeOpgaver));
        }

        private void TextBlock_SelectionChanged_3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMinProfil));
        }
    }
}
