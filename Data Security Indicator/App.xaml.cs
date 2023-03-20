using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Data_Security_Indicator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        public enum Websites
        {
            FACEBOOK, AMAZON, TIKTOK, LINKEDIN, SNAPCHAT, TWITTER, YOUTUBE, PINTEREST
        }

        // TODO: Replace "new Page()" with the specific page created (i.e. "new AmazonQAPage()", etc).
        public static Dictionary<App.Websites, Page> QAndA = new Dictionary<App.Websites, Page> 
        {
                {App.Websites.FACEBOOK, new FacebookQAPage() },
                {App.Websites.AMAZON, new Page() },
                {App.Websites.TIKTOK, new Page() },
                {App.Websites.LINKEDIN, new Page() },
                {App.Websites.SNAPCHAT, new Page() },
                {App.Websites.TWITTER, new Page() },
                {App.Websites.YOUTUBE, new Page() },
                {App.Websites.PINTEREST, new Page() }
        };

        public static List<Websites> sites= new List<Websites>();

    }
}
