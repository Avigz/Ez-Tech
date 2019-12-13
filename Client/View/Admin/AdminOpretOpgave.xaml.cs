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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View.Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminOpretOpgave : Page
    {
        public AdminOpretOpgave()
        {
            this.InitializeComponent();
          
        }
        public ViewModel.ViewModel vm = new ViewModel.ViewModel();
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


        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminPage));
        }

        private void MenuButton2_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminAktuelleOpgaver));
        }

        private void MenuButton3_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminHjælpere));
        }

        private void MenuButton4_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }

 

        private void TilknytKunde_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedKunde = (Kunder) TilknytKunde.SelectedItem;
        }
    
        private void Tilknyt_OnClick(object sender, RoutedEventArgs e)
        {
            vm.SelectedOpgave.ID = vm.OpgaveList.Count +1;
            vm.SelectedOpgave.KundeID = vm.SelectedKunde.KundeID;
            vm.SelectedOpgave.HjælperTilknyttet = null;
            vm.SelectedOpgave.IsDone = false;
            vm.AddOpgave(vm.SelectedOpgave);
        }

        private void BeskrivelseBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            vm.SelectedOpgave.Beskrivelse = BeskrivelseBox.Text.ToString();
        }

        private void Logaf_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }
    }
}
