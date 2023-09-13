﻿using System;
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
using Microsoft.Win32;

namespace TestLogin
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Login : Page, INavigationService
    {

        public Login()
        {
            InitializeComponent();
        }

        public event EventHandler<PageChangedEventArgs> PageChanged;

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textForRootPage.Text = LoginTextBox.Text;
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            PageChanged?.Invoke(this, new PageChangedEventArgs(new Registration()));
            
        }
    }
}