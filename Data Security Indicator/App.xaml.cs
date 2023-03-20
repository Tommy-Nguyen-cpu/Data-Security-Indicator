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
        public static List<Websites> sites= new List<Websites>();

    }
}
