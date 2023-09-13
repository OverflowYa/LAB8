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
    
namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window0 : Window
    {
        public Window0()
        {
            InitializeComponent();
        }
    
        private void LifeEvents(object sender, RoutedEventArgs e)
        {
            Window1 wnd1 = new Window1();
            wnd1.ShowInTaskbar = false; // Не показывать в панели задач
            wnd1.Show();          // Показать в модальном режиме
        }
    }
}
