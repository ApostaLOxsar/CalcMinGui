using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TestLogin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static List<Page> pages = new List<Page>(3) { new Login()};
        public MainWindow()
        {
            InitializeComponent();
            Registr.Navigate(new Login());
           /* MyClassEvent MyClassEvent = new MyClassEvent();
            MyClassEvent.MyDelegateEvent += PageSwap;*/

        }


        public void PageSwap()
        {
            Registr.Navigate(new Registration());
        }
    }
}
