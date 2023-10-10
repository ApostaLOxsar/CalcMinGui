using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using TestLogin;
using TestLogin.Logic.DateBase;

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

            bool chekLogin = ChekLogin(login);
            bool chekPass = ChekPass(pass, passRep);

            if (chekLogin && chekPass)
            {
                
                Login user = new Login(login, pass);
                MainWindow.locator.Data.Db.Logins.Add(user);
                MainWindow.locator.Data.Db.SaveChanges();
                List<Login> users = MainWindow.locator.Data.Db.Logins.ToList();
                /*string str = "";
                foreach (Login userList in users)
                {
                    str += "Login: " + userList.GetLogin + " | ";
                }
                textForRootPage.Text = str;*/
            }
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.GoToBackPage.MyEvent();
        }

        
        private bool ChekLogin(string username)
        {
            if (username.Length < 5)
            {
                NoCorectInp("Логин слишком короткий", ref LoginTextBox);
                return false;
            }
            else
            {
                CorectInp(ref LoginTextBox);
                return true;
            }
        }

        private bool ChekPass(string pass, string repPass)
        {
            if (pass.Length < 5)
            {
                NoCorectInp("Пароль слишком короткий", ref PasswordTextBox);
                return false;
            }
            else if (!Regex.IsMatch(pass, @"[a-zA-Z]+"))
            {
                NoCorectInp("Пароль должен содержать латинские символы", ref PasswordTextBox);
                return false;
            }
            else if (!Regex.IsMatch(pass, @"\d+"))
            {
                NoCorectInp("Пароль должен содержать не менее 1ой цифры", ref PasswordTextBox);
                return false;
            }
            else if (Regex.IsMatch(pass, @"\s+"))
            {
                NoCorectInp("Пароль не должен содержать пробелы", ref PasswordTextBox);
                return false;
            }
            else
            {
                CorectInp(ref PasswordTextBox);
            }

             if (pass != repPass)
            {
                NoCorectInp("Пароль не совпадает", ref PasswordRepeatTextBox);
                return false;
            } else CorectInp(ref PasswordRepeatTextBox);
           
            return true;
        }
        private void NoCorectInp<T>(string mess, ref T box) where T : Control
        {

            ToolTip toolTip = new ToolTip();
            toolTip.Content = mess;
            toolTip.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint;

            box.ToolTip = toolTip;
            box.Foreground = Brushes.Red;
            box.BorderBrush = Brushes.DarkRed;
        }

        private void CorectInp<T>(ref T box)  where T : Control
        {

            box.ToolTip = null;
            box.Foreground = Brushes.Green;
            box.BorderBrush = Brushes.DarkGreen;
        }
    }
}
