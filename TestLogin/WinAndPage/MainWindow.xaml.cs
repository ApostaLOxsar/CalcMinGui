using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Win32;

namespace TestLogin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MyClassEvent GoToPage = new MyClassEvent();
        public static MyClassEvent GoToBackPage = new MyClassEvent();
        public MainWindow()
        {
            InitializeComponent();
            Registr.Navigate(new Login());
            GoToPage.MyDelegateEvent += PageRegistration;
            GoToBackPage.MyDelegateEvent += PageBackSwap;
        }

        private void PageRegistration()
        {
            if (Registr.CanGoForward)
            {
                Registr.GoForward();
            }
            else Registr.Navigate(new Registration());
        }

        private void PageBackSwap()
        {
            Registr.GoBack();
        }
    }
}
