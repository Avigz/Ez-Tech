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
using Ez_Tech.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ez_Tech
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

           
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            //ViewModel.ViewModel vm = new ViewModel.ViewModel();
            //Hjælpere Test = new Hjælpere(2, "Christopher", "1234", "123", "123.com", false);

            //vm.HjælpereWebApi.Create(Test.ID, Test);
            Frame.Navigate(typeof(View.MainPageLogin));
        }
    }
}
