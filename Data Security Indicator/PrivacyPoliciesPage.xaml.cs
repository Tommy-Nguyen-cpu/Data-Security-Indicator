using System;
using System.Collections.Generic;
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

namespace Data_Security_Indicator
{
    /// <summary>
    /// Interaction logic for PrivacyPoliciesPage.xaml
    /// </summary>
    public partial class PrivacyPoliciesPage : Page
    {

        public class PrivacyPolicyPage
        {
            //public string? Facebook { get; set; }
            //public string? Amazon { get; set; }
            //public string? TikTok { get; set; }
            //public string? LinkedIn { get; set; }
            //public string? Snapchat { get; set; }
            //public string? Twitter { get; set; }
            //public string? YouTube { get; set; }
            //public string? Pinterest { get; set; }
        }

        public PrivacyPoliciesPage()
        {
            InitializeComponent();
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Name == "Facebook")
            {

            }
            else
            {

            }

            if (cb.Name == "Amazon")
            {

            }
            else
            {

            }

            if (cb.Name == "TikTok")
            {

            }
            else
            {

            }

            if (cb.Name == "LinkedIn")
            {

            }
            else
            {

            }

            if (cb.Name == "Snapchat")
            {

            }
            else
            {

            }

            if (cb.Name == "Twitter")
            {

            }
            else
            {

            }

            if (cb.Name == "YouTube")
            {

            }
            else
            {

            }

            if (cb.Name == "Pinterest")
            {

            }
            else
            {

            }
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PrivacyQuestionairePage());
        }
    }
}
