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
    /// Interaction logic for TikTokQAPage.xaml
    /// </summary>
    public partial class TikTokQAPage : Page
    {
        public TikTokQAPage()
        {
            InitializeComponent();
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
            if (App.sites.Any())
            {
                App.sites.RemoveAt(0);
                System.Diagnostics.Debug.WriteLine("next is: " + App.sites.FirstOrDefault());
                this.NavigationService.Navigate(App.QAndA[App.sites.First()]);
            }
        }
    }
}
