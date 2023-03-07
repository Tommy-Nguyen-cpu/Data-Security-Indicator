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

namespace Data_Security_Indicator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {

        private Dictionary<string, string> pages = new Dictionary<string, string>{
            {"Phishing Scheme", "PhishingSchemePage.xaml" },
            {"Privacy Policies", "PrivacyPoliciesPage.xaml" }
        };

        //private NavigationWindow window = new NavigationWindow();
        public MainWindow()
        {
            InitializeComponent();

/*            window.Source = new Uri("PhishingSchemePage.xaml", UriKind.Relative);
            window.Show();*/
            /*this.Content = new PhishingSchemePage();*/
        }

        private void LOGIN_CLICK(object sender, RoutedEventArgs e)
        {
            if(Username.Text.Length > 0 && Password.Password.Length > 0)
            {
                this.NavigationService.Navigate(new PhishingSchemePage(Username.Text, Password.Password));
            }

        }
    }
}
