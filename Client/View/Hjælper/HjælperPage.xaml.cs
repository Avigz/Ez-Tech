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

        private void Forside_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View.Admin.AdminPage));
        }

        private void MenuButton4_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton6_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton7_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton8_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HamburgerButton_OnChecked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBlock_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton5_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
