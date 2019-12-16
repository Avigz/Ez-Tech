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
    public sealed partial class HjælpereFærdigeOpgaver : Page
    {
        public HjælpereFærdigeOpgaver()
        {
            this.InitializeComponent();
        }

        private void Forside_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMinProfil));
        }

        private void LedigeOpgaver_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperPage));
        }

        private void MinProfil_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMinProfil));
        }

        private void HamburgerButton_OnChecked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }

        private void Lv_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }

        private void MineOpgaver_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HjælperMineOpgaver));
        }

        private void Logaf_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageLogin));
        }
    }
}
