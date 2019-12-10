using System;
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

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void MenuButton1_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton3_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperPage));
        }

        private void TextBlock_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
            Hjælpere Default = new Hjælpere(0, "Indtast Navn", "Indtast Nummer", "indtask kodeord", "indtast email", false);
            vm.SelectedHjælper = Default;

        }


        private void ListViewHjælpere_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedHjælper = (Hjælpere)ListViewHjælpere.SelectedItem;
        }

        private void MenuButton6_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton4_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton5_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    

}
