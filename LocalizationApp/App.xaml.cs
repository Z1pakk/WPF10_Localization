using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace LocalizationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            using(FileStream fs=new FileStream("language.ini", FileMode.Open, FileAccess.Read))
            {
                using(StreamReader sr=new StreamReader(fs))
                {
                    string language = sr.ReadLine();
                    if (!string.IsNullOrEmpty(language))
                    {
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                    }
                   
                }
            }
        }
    }
}
