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

namespace P4.Zadanie_3
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
            if (!double.TryParse(Box1.Text, out double number))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(Box2.Text, out double znachenie))
            { MessageBox.Show("Поле только для чисел"); }
            double R = 0;
            double D = 0;
            double L = 0;
            double S = 0;
            switch (number)
            {
                case 1:
                    Answer.Text += R = znachenie;
                    D = 2 * R;
                    L = 2 * 3.14 * R;
                    S = 3.14 * R * R;
                    break;
                case 2:
                    D = znachenie; R = D / 2; L = 2 * 3.14 * R; S = 3.14 * R * R;
                    break;
                case 3:
                    L = znachenie; R = L / (2 * 3.14); D = 2 * R; S = 3.14 * R * R;
                    break;
                case 4:
                    S = znachenie; R = Math.Sqrt(S / 3.14); D = 2 * R; L = 2 * 3.14 * R;
                    break;

            }

            Answer.Text += $" D = {D:f2} R = {R:f2} L = {L:f2} S = {S:f2}";

        }
    }
}
