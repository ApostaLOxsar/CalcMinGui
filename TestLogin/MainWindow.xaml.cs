using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.SqlServer.Server;

namespace TestLogin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Page> pages = new List<Page>(3) { new Login()};
        public MainWindow()
        {
            InitializeComponent();
            Registr.Navigate(pages[pages.Count - 1]);
        }

        public void Pages()
        {
            Registr.Navigate(pages[pages.Count - 1]);
        }

        private void Page1_PageChanged(object sender, PageChangedEventArgs e)
        {
            Registr.Navigate(e.Page);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (Registr.Content == null)
            {
                Registr.Navigate(new Login());
            }
        }

    }
}
