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
    public sealed partial class AdminKunder : Page
    {
        public AdminKunder()
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
            vm.UpdateKunde(vm.SelectedKunde);
        }

        private void Slet_OnClick(object sender, RoutedEventArgs e)
        {
            vm.RemoveKunde(vm.SelectedKunde);
        }

        private void Opret_OnClick(object sender, RoutedEventArgs e)
        {
            ListViewKunder.SelectedItem = null;
            vm.SelectedKunde = new Kunder();
            vm.SelectedKunde.KundeAdresse = AdresseBox.Text;
            vm.SelectedKunde.KundeNavn = NavnBox.Text;
            vm.SelectedKunde.KundeNummer = TlfBox.Text;
            vm.SelectedKunde.KundeID= vm.KunderList.Count + 1;
            vm.AddKunde(vm.SelectedKunde);


        }


        private void ListViewKunder_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedKunde = (Kunder)ListViewKunder.SelectedItem;
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
            vm.SelectedKunde.KundeNavn = NavnBox.Text;
        }

        private void AdresseBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedKunde.KundeAdresse = AdresseBox.Text;
        }


        private void TlfBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedKunde.KundeNummer = TlfBox.Text;
        }


        

        private void Logaf_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void AdminHjælpere_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminHjælpere));
        }
    }



}
