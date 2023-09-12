using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows;
    
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // Подписались на событие, что запущен объект Application 
            this.Startup += new StartupEventHandler(App_Startup);
            // На всякий случай подписались на событие необработанных исключений
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }
    
        void App_DispatcherUnhandledException(object sender, 
            System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;// Продолжить выполнение
        }
    
        void App_Startup(object sender, StartupEventArgs e)
        {
            // Создаем объект стартового окна
            Window1 win = new Window1();
            // Настраиваем объект окна
            win.Title = "Перекрывающий заголовок окна";
            // Показываем окно
            win.Show();
        }
    }
}
