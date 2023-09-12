
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void LinkClicked(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            page2.Message = nameBox.Text + " !!";// Зашиваем информацию в объект страницы
            this.NavigationService.Navigate(page2);
        }
    }
}

