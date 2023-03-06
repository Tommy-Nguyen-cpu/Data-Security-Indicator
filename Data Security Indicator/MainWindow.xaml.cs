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
    public partial class MainWindow : Window
    {
        public class PhishingInfoExample
        {
            public string? TotalFreeSpace { get; set; }
            public string? FilesInRoot { get; set; }
        }


        public MainWindow()
        {
            InitializeComponent();

            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            string totalSpace = $"{di.TotalFreeSpace / 1073741824}";
            System.Diagnostics.Debug.WriteLine(di.TotalFreeSpace/ 1073741824);

            // Get the root directory and print out some information about it.
            System.IO.DirectoryInfo dirInfo = di.RootDirectory;

            // Get the files in the directory and print out some information about them.
            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");
            string files = "";
            for(int i = 0; i < fileNames.Length; i++)
            {
                files += $"{fileNames[i].Name}({fileNames[i].LastAccessTime}), ";
            }

            // Get the subdirectories directly that is under the root.
            // See "How to: Iterate Through a Directory Tree" for an example of how to
            // iterate through an entire tree.
            System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            for(int i = 0; i < dirInfos.Length; i++)
            {
                files += $"{dirInfos[i].Name} ({dirInfos[i].LastAccessTime})";
                if (i + 1 < dirInfos.Length)
                    files += ", ";
            }

            DataContext = new PhishingInfoExample() { TotalFreeSpace= totalSpace, FilesInRoot= files };
        }
    }
}
