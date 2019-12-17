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

namespace Client.View.Forside
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OmOs : Page
    {
        public OmOs()
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
        private void HamburgerButton_OnChecked1(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuButton1_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(sourcePageType: typeof(MainPageLogin));
        }

        private void MenuButton2_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OmOs));
        }
    }
}
