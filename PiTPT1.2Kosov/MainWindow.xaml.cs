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

namespace PiTPT1._2Kosov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void Solving(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(Nletter.Text, out int N) && N > 0)
            {
                int[] mass = new int[N];
                Random rnd = new Random();
                for (int i = 0; i < N; i++)
                {
                    mass[i] = rnd.Next(-9, 10);
                }

                int kol = 0;
                for (int i = 0; i < N - 1; i++)
                {
                    if (mass[i] < 0 && mass[i + 1] >= 0) kol++;
                    else if (mass[i] >= 0 && mass[i + 1] < 0) kol++;
                }

                string AllTime = "";
                foreach (var nameee in mass)
                {
                    AllTime += nameee + "\n";
                }

                MessageBox.Show("Массив:\n" + AllTime + "\n" + "Кол-во смен знака: " + kol);
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
