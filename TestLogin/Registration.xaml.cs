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

namespace TestLogin
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string pass = PasswordTextBox.Password;
            string passRep = PasswordRepeatTextBox.Password;

            if (login.Length < 5)
            {
                LoginTextBox.ToolTip = "Недопустимая длинна";
                LoginTextBox.Foreground = Brushes.Red;
                LoginTextBox.BorderBrush = Brushes.DarkRed;
            }
            else
            {
                LoginTextBox.Foreground = Brushes.Green;
                LoginTextBox.BorderBrush = Brushes.DarkGreen;
            }


        }
    }
}
