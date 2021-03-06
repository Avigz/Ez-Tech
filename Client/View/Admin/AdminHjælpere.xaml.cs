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
using Client.Model;
using Client.View.Hjælper;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View.Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminHjælpere : Page
    {
        public AdminHjælpere()
        {
            this.InitializeComponent();

        }
        ViewModel.ViewModel vm = new ViewModel.ViewModel();
        
	
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

       

       

        private void Opdater_OnClick(object sender, RoutedEventArgs e)
        {
           vm.UpdateHjælper(vm.SelectedHjælper);
        }

        private void Slet_OnClick(object sender, RoutedEventArgs e)
        {
            vm.RemoveHjælper(vm.SelectedHjælper);
        }

        private void Opret_OnClick(object sender, RoutedEventArgs e)
        {
            ListViewHjælpere.SelectedItem = null;
            vm.SelectedHjælper = new Hjælpere();
            vm.SelectedHjælper.ID = vm.HjælperList.Count + 1;
            vm.AddHjælper(vm.SelectedHjælper);
            

        }


        private void ListViewHjælpere_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedHjælper = (Hjælpere)ListViewHjælpere.SelectedItem;
        }


        private void MenuButton1_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminPage));
        }

        private void MenuButton3_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminAktuelleOpgaver));
        }


        private void MenuButton6_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminOpretOpgave));
        }

        private void MenuButton4_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminHjælpere));
        }

        private void MenuButton5_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }

        

        private void NavnBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedHjælper.Navn = NavnBox.Text;
        }

        private void EmailBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedHjælper.Email = EmailBox.Text;
        }


        private void TlfBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedHjælper.TelefonNummer = TlfBox.Text;
        }


        private void KodeBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedHjælper.Kodeord = KodeBox.Text;
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
