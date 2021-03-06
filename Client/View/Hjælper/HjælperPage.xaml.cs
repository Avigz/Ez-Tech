﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Client.Model;
using Client.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View.Hjælper

{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HjælperPage : Page
    {



        public HjælperPage()
        {
            this.InitializeComponent();
          

            

        }

        ViewModel.ViewModel vm = new ViewModel.ViewModel();

        private void Forside_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void MenuButton4_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMineOpgaver));
        }

        private void MenuButton6_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælpereFærdigeOpgaver));
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




   



        private void LedigeOpgaverCombo_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedOpgave = (Opgaver) LedigeOpgaverCombo.SelectedItem;
        }

        private void Tilknyt(object sender, RoutedEventArgs e)
        {
            vm.SelectedOpgave.HjælperTilknyttet = vm.LoggedIndHjælper.ID;
            vm.UpdateOpgave(vm.SelectedOpgave);
        }

        private void Logaf_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }
    }
}