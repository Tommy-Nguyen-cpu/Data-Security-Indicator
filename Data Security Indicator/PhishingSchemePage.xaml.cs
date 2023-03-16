using System;
using System.Collections.Generic;
using System.Linq;
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
using static Data_Security_Indicator.MainWindow;

namespace Data_Security_Indicator
{
    /// <summary>
    /// Interaction logic for PhishingSchemePage.xaml
    /// </summary>
    public partial class PhishingSchemePage : Page
    {
        public class PhishingInfoExample
        {
            public string? Username { get; set; }
            public string? Password { get; set; }
        }

        public PhishingSchemePage(string username, string password)
        {
            InitializeComponent();
            

            DataContext = new PhishingInfoExample() { Username = username, Password = password };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PrivacyPoliciesPage(false, false, false, false, false, false, false, false));
        }
    }
}
