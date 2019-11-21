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
        }
      ViewModel.ViewModel vm = new ViewModel.ViewModel();
          

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.ConfirmLogin();
            if (vm.LoginObject.LoginSuccesfull == true)
            {
                Frame.Navigate(typeof(View.AdminPage));
            }
            else
            {
                
            }

           
        }
    }
}
