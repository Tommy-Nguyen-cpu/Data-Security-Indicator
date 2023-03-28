using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for FacebookQAPage.xaml
    /// </summary>
    public partial class FacebookQAPage : Page
    {
        public FacebookQAPage()
        {
            InitializeComponent();            
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
            if (App.sites.Count == 0)
            {
                App.sites.RemoveAt(0);
                System.Diagnostics.Debug.WriteLine("next is: " + App.sites.FirstOrDefault());
                this.NavigationService.Navigate(App.QAndA[App.sites.First()]);
            }
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            QA1ans.Text = "TRUE";
            QA2ans.Text = "TRUE";
            QA3ans.Text = "FALSE";
            QA4ans.Text = "FALSE";
            QA5ans.Text = "TRUE";

            if ((bool)QA1.IsChecked)
            {
                QA1.Foreground = Brushes.Blue;
            }
            else
            {
                QA1.Foreground = Brushes.Red;
            }
            if ((bool)QA2.IsChecked)
            {
                QA2.Foreground = Brushes.Blue;
            }
            else
            {
                QA2.Foreground = Brushes.Red;
            }
            if (!(bool)QA3.IsChecked)
            {
                QA3.Foreground = Brushes.Blue;
            }
            else
            {
                QA3.Foreground = Brushes.Red;
            }
            if (!(bool)QA4.IsChecked)
            {
                QA4.Foreground = Brushes.Blue;
            }
            else
            {
                QA4.Foreground = Brushes.Red;
            }
            if ((bool)QA5.IsChecked)
            {
                QA5.Foreground = Brushes.Blue;
            }
            else
            {
                QA5.Foreground = Brushes.Red;
            }
            FacebookANS Facebook = new FacebookANS();
            Facebook.Show();
        }
    }
}
