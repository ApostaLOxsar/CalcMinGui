using System;
using System.Collections.Generic;
using System.Data;
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

namespace TimeOff
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*foreach (UIElement el in rootInterf.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (String)((Button)e.OriginalSource).Content;
            if (str == "AC")
            {
                result.Text = "";
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(result.Text, null).ToString();
                result.Text = value;
            }
            else
            {
                result.Text += str;
            }
        }
    }
}
