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
    /// Interaction logic for AmazonQAPage.xaml
    /// </summary>
    public partial class AmazonQAPage : Page
    {
        public AmazonQAPage()
        {
            InitializeComponent();
        }
        
        private void Continue(object sender, RoutedEventArgs e)
        {
            App.sites.RemoveAt(0);
            System.Diagnostics.Debug.WriteLine("next is: " + App.sites.FirstOrDefault());
            this.NavigationService.Navigate(App.QAndA[App.sites.First()]);
        }
    }
}
