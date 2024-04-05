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

namespace TekCont
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

        public bool Proverka(string task1, string task2, string task3, string task4)
        {
            if (!string.IsNullOrEmpty(task1) && !string.IsNullOrEmpty(task2) && !string.IsNullOrEmpty(task3) && !string.IsNullOrEmpty(task4))
            {
                int xsmall;
                int ismall;
                int ysmall;
                int dsafcas;
                bool isnumx = int.TryParse(task1, out xsmall);
                bool isnumi = int.TryParse(task2, out ismall);
                bool issmaksa = int.TryParse(task3, out ysmall);
                bool iasdasa = int.TryParse(task4, out dsafcas);
                if (isnumx && isnumi && issmaksa && iasdasa)
                {
                    if (int.Parse(task1) > 10)
                    {
                        MessageBox.Show("Максимальный балл за первое задание 10");
                        return false;
                    }
                    else if (int.Parse(task2) > 50)
                    {
                        MessageBox.Show("Максимальный балл за второе задание 50");
                        return false;
                    }
                    else if (int.Parse(task3) > 30)
                    {
                        MessageBox.Show("Максимальный балл за третье задание 30");
                        return false;
                    }
                    else if (int.Parse(task4) > 10)
                    {
                        MessageBox.Show("Максимальный балл за четвёртное задание 10");
                        return false;
                    }
                    else
                    {
                        int sum = 0;
                        sum += int.Parse(task1);
                        sum += int.Parse(task2);
                        sum += int.Parse(task3);
                        sum += int.Parse(task4);

                        if (sum <= 19)
                        {
                            Vivod_teg.Text = "Оценка «2» (неудовлетворительно), кол-во баллов";
                            return true;
                        }
                        else if (sum <= 39)
                        {
                            Vivod_teg.Text = "Оценка «3» (удовлетворительно)";
                            return true;
                        }
                        else if (sum <= 69)
                        {
                            Vivod_teg.Text = "Оценка «4» (хорошо)";
                            return true;
                        }
                        else if (sum <= 100)
                        {
                            Vivod_teg.Text = "Оценка «5» (отлично)";
                            return true;

                        }
                        return true;
                    }
                
                }
                else
                {
                    MessageBox.Show("Введите целое число!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введите все баллы");
                return false;
            }
        }

        private void Proverka_but_Click(object sender, RoutedEventArgs e)
        {
            Proverka(Task1_Text.Text, Task2_Text.Text, Task3_Text.Text, Task4_Text.Text);
        }
    }
}
