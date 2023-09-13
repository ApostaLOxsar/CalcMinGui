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
        public static MyClassEvent myClassEvent = new MyClassEvent();
        public MainWindow()
        {
            InitializeComponent();
            Registr.Navigate(new Login());
            myClassEvent.MyDelegateEvent += PageSwap;
        }

        public void PageSwap(Page page)
        {
            Registr.Navigate(page);
        }

        public double[] GetHeightWidth()
        {
            return new double[] {ActualHeight, ActualWidth};
        }
    }
}
