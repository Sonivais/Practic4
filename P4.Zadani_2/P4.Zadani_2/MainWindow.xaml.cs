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

namespace P4.Zadani_2
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
            if(!double.TryParse(TextBox1.Text, out double age ))
            { MessageBox.Show("Поле только для чисел");}
            double age2;
            switch (age)
            {
                case 20:
                    Answer.Text += "Двадцать лет";
                    break;
                case 21:
                    Answer.Text += "Двадцать один год";
                    break;
                case 22:
                    Answer.Text += "Двадцать два года";
                    break;
                case 23:
                    Answer.Text += "Двадцать три года";
                    break;
                case 24:
                    Answer.Text += "Двадцать четыри года";
                    break;
                case 25:
                    Answer.Text += "Двадцать пять лет";
                    break;
                case 26:
                    Answer.Text += "Двадцать шесть лет";
                    break;
                case 27:
                    Answer.Text += "Двадцать семь лет";
                    break;
                case 28:
                    Answer.Text += "Двадцать восемь лет";
                    break;
                case 29:
                    Answer.Text += "Двадцать девять лет";
                    break;
                case 30:
                    Answer.Text += "Тридцать лет";
                    break;
                case 31:
                    Answer.Text += "Тридцать один год";
                    break;
                case 32:
                    Answer.Text += "Тридцать три года";
                    break;
                case 33:
                    Answer.Text += "Тридцать три года";
                    break;
                case 34:
                    Answer.Text += "Тридцать четыре года";
                    break;
                case 35:
                    Answer.Text += "Тридцать пять лет";
                    break;
                case 36:
                    Answer.Text += "Тридцать шесть лет";
                    break;
                case 37:
                    Answer.Text += "Тридцать семь лет";
                    break;
                case 38:
                    Answer.Text += "Тридцать восемь лет";
                    break;
                case 39:
                    Answer.Text += "Тридцать девять лет";
                    break;
                case 40:
                    Answer.Text += "Сорок лет";
                    break;
                case 41:
                    Answer.Text += "Сорок один год";
                    break;
                case 42:
                    Answer.Text += "Сорок два года";
                    break;
                case 43:
                    Answer.Text += "Сорок три года";
                    break;
                case 44:
                    Answer.Text += "Сорок четыре года";
                    break;
                case 45:
                    Answer.Text += "Сорок пять лет";
                    break;
                case 46:
                    Answer.Text += "Сорок шесть лет";
                    break;
                case 47:
                    Answer.Text += "Сорок семь дет";
                    break;
                case 48:
                    Answer.Text += "Сорок восемь лет";
                    break;
                case 49:
                    Answer.Text += "Сорок девять лет";
                    break;
                case 50:
                    Answer.Text += "Пятьдесят лет";
                    break;
                case 51:
                    Answer.Text += "Пятьдесят один год";
                    break;
                case 52:
                    Answer.Text += "Пятьдесят два года";
                    break;
                case 53:
                    Answer.Text += "Пятьдесят три года";
                    break;
                case 54:
                    Answer.Text += "Пятьдесят четыри года";
                    break;
                case 55:
                    Answer.Text += "Пятьдесят пять лет";
                    break;
                case 56:
                    Answer.Text += "Пятьдесят шесть лет";
                    break;
                case 57:
                    Answer.Text += "Пятьдесят семь лет";
                    break;
                case 58:
                    Answer.Text += "Пятьдесят восемь лет";
                    break;
                case 59:
                    Answer.Text += "Пятьдесят девять лет";
                    break;
                case 60:
                    Answer.Text += "Шестьдесят лет";
                    break;
                case 61:
                    Answer.Text += "Шестьдесят один год";
                    break;
                case 62:
                    Answer.Text += "Шестьдесят два года";
                    break;
                case 63:
                    Answer.Text += "Шестьдесят три года";
                    break;
                case 64:
                    Answer.Text += "Шестьдесят четыри года";
                    break;
                case 65:
                    Answer.Text += "Шестьдесят пять лет";
                    break;
                case 66:
                    Answer.Text += "Шестьдесят шесть лет";
                    break;
                case 67:
                    Answer.Text += "Шестьдесят семь лет";
                    break;
                case 68:
                    Answer.Text += "Шестьдесят восемь лет";
                    break;
                case 69:
                    Answer.Text += "Шестьдесят девять лет";
                    break;
               
            }
        }
    }
}
