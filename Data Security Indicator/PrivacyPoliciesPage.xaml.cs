using System;
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
        public class Media
        {
            public bool? Facebook{ get; set; }
            public bool? Amazon{ get; set; }
            public bool? TikTok { get; set; }
            public bool? LinkedIn { get; set; }
            public bool? Snapchat { get; set; }
            public bool? Twitter { get; set; }
            public bool? YouTube { get; set; }
            public bool? Pinterest { get; set; }
        }

        public PrivacyPoliciesPage()
        {
            InitializeComponent();

            DataContext = new Media() { };
        }
        
        private void Continue(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PrivacyQuestionairePage(Facebook.IsChecked.Value, Amazon.IsChecked.Value, TikTok.IsChecked.Value, LinkedIn.IsChecked.Value, Snapchat.IsChecked.Value, Twitter.IsChecked.Value, YouTube.IsChecked.Value, Pinterest.IsChecked.Value));
        }
    }
}
