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
    
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        System.Windows.Media.Brush color;
        bool colorFlag = true;
    
        public Window1()
        {
            //InitializeComponent();
            Application.LoadComponent(this, new Uri("Window1.xaml", UriKind.Relative));
    
            // Регистрируем обработчик события щелчка на кнопке Btn1
            Btn1.Click += new RoutedEventHandler(Btn1_Click);
            // Запоминаем начальный цвет фона окна
            color = this.Window.Background;
        }
    
        void Btn1_Click(object sender, RoutedEventArgs e)
        {
            // Меняем цвет фона кнопки 
            if (colorFlag)
                this.Window.Background = System.Windows.Media.Brushes.White;
            else
                this.Window.Background = color;
    
            colorFlag = !colorFlag;
        }
    }
}
