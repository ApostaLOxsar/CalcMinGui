using System.Windows;
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
        }
        
    }
}
