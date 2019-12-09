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
    public sealed partial class AdminAktuelleOpgaver : Page
    {
        public AdminAktuelleOpgaver()
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

        //private void AdminAktuelleSiderForside_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(AdminLogin));
        //}

        private void AdminAktuelleOpgaver_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminAktuelleOpgaver));
        }

        private void AdminAktuelleOpgaverHjælpere_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminHjælpere));
        }

        private void TextBlock_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AdminAktuelleOpgaverAfsluttet_OnClick_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }

        private void Hjælpere_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void Forside_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton3_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FærdigeOpgaver_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }

        private void Lv_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedOpgave = (Opgaver)Lv.SelectedItem;
        }

        private void DoneClick(object sender, RoutedEventArgs e)
        {
            vm.SelectedOpgave.IsDone = true;
            vm.UpdateOpgave(vm.SelectedOpgave);
        
        }

        private void OpdaterClick(object sender, RoutedEventArgs e)
        {
           vm.UpdateOpgave(vm.SelectedOpgave);
        }
        private void SletClick(object sender, RoutedEventArgs e)
        {
            vm.RemoveOpgaver(vm.SelectedOpgave);
        }

        private void _OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdminFærdigeOpgaver1));
        }
    }
}