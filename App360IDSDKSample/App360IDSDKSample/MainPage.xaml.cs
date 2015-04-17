using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using App360IDSDKSample.Resources;
using App360IDSDK;

namespace App360IDSDKSample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            App360ID.Initialize("1004040765404587566376", "");
            App360ID.OnLogin += App360ID_OnLogin;
        }

        void App360ID_OnLogin(UserInfo sender, LoginEventArgs args)
        {
            if (args.IsSucess)
            {
                MessageBox.Show(sender.DisplayName);
            }
            else
            {
                MessageBox.Show(args.Error);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App360ID.Login("basic");
        }

    }
}