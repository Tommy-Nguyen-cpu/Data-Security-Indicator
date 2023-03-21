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
            {App.Websites.AMAZON, new AmazonQAPage() },
            {App.Websites.TIKTOK, new TikTokQAPage() },
            {App.Websites.LINKEDIN, new LinkedInQAPage() },
            {App.Websites.SNAPCHAT, new SnapchatQAPage() },
            {App.Websites.TWITTER, new TwitterQAPage() },
            {App.Websites.YOUTUBE, new YouTubeQAPage() },
            {App.Websites.PINTEREST, new PinterestQAPage() },
            {App.Websites.FACEBOOK, new FacebookQAPage() }
        };

        public static List<Websites> sites= new List<Websites>();

    }
}
