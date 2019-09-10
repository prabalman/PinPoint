using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Storage.Pickers;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Activation;
using Windows.Storage;

namespace PinPoint_v3._0
{
    public partial class Victim : PhoneApplicationPage
    {
        public Victim()
        {
            InitializeComponent();
        }

       

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}