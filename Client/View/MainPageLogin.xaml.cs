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
using Client.ViewModel;
using Client;
using Client.View.Forside;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPageLogin : Page
    {
        public MainPageLogin()
        {
            this.InitializeComponent();
            this.DataContext = vm;


        }
        ViewModel.ViewModel vm = new ViewModel.ViewModel();


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (vm.ConfirmLogin() == true)
            {
                if (vm.LoggedIndHjælper.IsAdmin)
                {
                    Frame.Navigate(typeof(View.Admin.AdminPage));
                    
                }
                else if (vm.LoggedIndHjælper.IsAdmin == false)
                {
                    Frame.Navigate(typeof(View.Hjælper.HjælperPage));
                }
            }
          

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

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OmOs));
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            vm.Password = PasswordBox.Password;
        }
    }
}
