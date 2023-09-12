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
using System.Windows.Shapes;
    
namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for WindowList.xaml
    /// </summary>
    public partial class WindowList : Window
    {
        static int createCount;
        public WindowList()
        {
            InitializeComponent();
    
            // Определение заголовка окна и назначение главного окна
            if (createCount == 3)
            {
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Application.Current.MainWindow = this;
                this.Title = "Главное окно № " + (createCount++).ToString();
            }
            else
                this.Title = "Окно № " + (createCount++).ToString();
        }
    
        private void NewWindowClicked(object sender, RoutedEventArgs e)
        {
            new WindowList().Show();
        }
    
        private void ListOpenWindows(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Window openWindow in Application.Current.Windows)
                sb.AppendLine(openWindow.Title);
    
            MessageBox.Show(sb.ToString(), "Открытые окна ");
        }
    
        private void AllCloseWindows(object sender, RoutedEventArgs e)
        {
            //Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();// Закрывает при любом режиме
        }
    }
}
