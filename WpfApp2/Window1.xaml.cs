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
    
namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            System.Diagnostics.Debug.WriteLine("Сработал конструктор окна");
    
            InitializeComponent();
        }
    
        private void Window_Initialized(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Initialized окна");
        }
    
        private void Window_Activated(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Activated окна");
        }
    
        private void Window_Deactivated(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Deactivated окна");
        }
    
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Loaded окна");
        }
    
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие ContentRendered окна");
        }
    
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Closing окна");
            if (MessageBox.Show("Вы уверены, что хотите закрыть окно?",
                "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.No)
                e.Cancel = true; // Не закрывать
        }
    
        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Unloaded окна");
        }
    
        private void Window_Closed(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Возбудилось событие Closed окна");
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
