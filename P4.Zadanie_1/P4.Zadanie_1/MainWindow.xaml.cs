using System;
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

namespace P4.Zadanie_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(TextBox1.Text,out double number))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(TextBox2.Text, out double lenght))
            { MessageBox.Show("Поле только для чисел"); }
            double result;
            switch (number)
            {
                case 1:
                    result = lenght * 0.1;
                    break;
                case 2:
                    result = lenght * 1000;
                    break;
                case 3:
                    result = lenght;
                    break;
                case 4:
                    result = lenght * 0.001;
                    break;
                case 5:
                    result = lenght * 0.01;
                    break;
                default:
                    { MessageBox.Show("Некорректный номер единицы длины");}
                    return;
            }
            Answer.Text += "Длина трезка " + result;
        }
    }
}
