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
    /// Interaction logic for PrivacyQuestionairePage.xaml
    /// </summary>
    public partial class PrivacyQuestionairePage : Page
    {

        public enum Websites
        {
            FACEBOOK, AMAZON, TIKTOK, LINKEDIN, SNAPCHAT, TWITTER, YOUTUBE, PINTEREST
        }

        // TODO: Replace "new Page()" with the specific page created (i.e. "new AmazonQAPage()", etc).
        Dictionary<Websites, Page> QAndA = new Dictionary<Websites, Page> {
            {Websites.FACEBOOK, new FacebookQAPage() },
            {Websites.AMAZON, new Page() },
            {Websites.TIKTOK, new Page() },
            {Websites.LINKEDIN, new Page() },
            {Websites.SNAPCHAT, new Page() },
            {Websites.TWITTER, new Page() },
            {Websites.YOUTUBE, new Page() },
            {Websites.PINTEREST, new Page() }
        };


        public PrivacyQuestionairePage(List<Websites> sitesUsed)
        {
            InitializeComponent();

        }
    }
}
