﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Data_Security_Indicator.PhishingSchemePage;

namespace Data_Security_Indicator
{
    /// <summary>
    /// Interaction logic for PrivacyPoliciesPage.xaml
    /// </summary>
    public partial class PrivacyPoliciesPage : Page
    {

        public PrivacyPoliciesPage()
        {
            InitializeComponent();
        }
        
        private void Continue(object sender, RoutedEventArgs e)
        {
            List<bool> sitesPicked = new List<bool> { Facebook.IsChecked.Value, Amazon.IsChecked.Value, TikTok.IsChecked.Value, LinkedIn.IsChecked.Value, Snapchat.IsChecked.Value, Twitter.IsChecked.Value, YouTube.IsChecked.Value, Pinterest.IsChecked.Value };

            for(int i = 0; i < sitesPicked.Count; i++)
            {
                if (sitesPicked[i])
                {
                    App.sites.Add((Data_Security_Indicator.App.Websites)(App.Websites)i);
                }
            }

            foreach(var site in App.sites)
            {
                System.Diagnostics.Debug.WriteLine("Site picked: " + site);
            }

            // TODO: navigate to the first page on the list

            this.NavigationService.Navigate(App.QAndA[App.sites.First()]);
        }
    }
}
