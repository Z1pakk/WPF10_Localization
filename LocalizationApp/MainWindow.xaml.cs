using System;
using System.Collections.Generic;
using System.IO;
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

namespace LocalizationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnUkraine_Click(object sender, RoutedEventArgs e)
        {
            using(FileStream fs=new FileStream("language.ini", FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter sw=new StreamWriter(fs))
                {
                    sw.WriteLine("uk");
                }
            }
            this.Restart();
        }

        private void btnPoland_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("language.ini", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("pl-PL");
                }
            }
            this.Restart();
        }

        private void Restart()
        {
            System.Diagnostics.Process.Start(
                Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
