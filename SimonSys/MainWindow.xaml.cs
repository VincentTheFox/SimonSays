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

namespace SimonSys
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mass2 = new int[9]; //массив вводимых игроком значений
        int[] mass = new int[9]; //массив вводимых игрой значений
        int maxmass;
        int currentround; //текущий раун игры
        int currentplaymass = 0; //текущее количество заполненых элементов в массиве
        int currentScore; //текущий счёт
        public MainWindow()
        {
            InitializeComponent();
            StartWaitLabel.Content = "";

        }

        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 8 )
            {
                mass2[currentplaymass + maxmass] = 1; //если число заполненых элементов в массиве не равно 9 то в массив записывается новое значение а число увеличивапется
                currentplaymass++;
            }
            else
            {
                _check(); //если число заполненных эементов в массиве равно 9 то запускается процесс проверки и посдсчёта очков
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass + maxmass] = 2;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 3;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 4;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 5;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 6;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 7;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 8;
                currentplaymass++;
            }
            else
            {
                _check();
            }
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass != 9)
            {
                mass2[currentplaymass] = 9;
                currentplaymass++;
            }
            else
            {
                _check();
            }

        }
        private void _check()
        {
            if (mass2.SequenceEqual(mass) && currentplaymass == 8)
            {
                StartWaitLabel.Content = "YouWin";
                currentScore = Convert.ToInt32(CurrentScore.Text);
                currentScore++;
                CurrentScore.Text = currentScore.ToString();
            }
            if (mass2.SequenceEqual(mass) != true || currentplaymass == 8)
            {
                StartWaitLabel.Content = "";
                StartWaitLabel.Foreground = Brushes.Red;
                StartWaitLabel.Content = "YouLose";
                currentround = 0;
                currentplaymass = 0;
            }
                MassBlock.Text += " ";
                for (int j = currentplaymass; j < currentround; j++)
                {
                    MassBlock.Text += mass2[j].ToString();
                }

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void _clearAll()
        {
            Button1Exc.Background = Brushes.LightGray;
            Button2Exc.Background = Brushes.LightGray;
            Button3Exc.Background = Brushes.LightGray;
            Button4Exc.Background = Brushes.LightGray;
            Button5Exc.Background = Brushes.LightGray;
            Button6Exc.Background = Brushes.LightGray;
            Button7Exc.Background = Brushes.LightGray;
            Button8Exc.Background = Brushes.LightGray;
            Button9Exc.Background = Brushes.LightGray;
        }
        private  async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentplaymass == 8)
            {
                currentround = 0;
                
            }
            currentround++;
            currentplaymass = 0;

            maxmass++;
            _check();
            StartWaitLabel.Foreground = Brushes.Red;
            StartWaitLabel.Content = "WAIT";
            MassBlock.Text = "";
            Random r = new Random();
            
            
            
            for(int i = currentplaymass; i < currentround; i++)
            {
                int rener = Convert.ToInt32(r.Next(1,9));
               
                switch (rener) 
                {
                    case 1:
                        mass[i] = rener;
                        Button1Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 2:
                        mass[i] = rener;
                        Button2Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 3:
                        mass[i] = rener;
                        Button3Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 4:
                        mass[i] = rener;
                        Button4Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 5:
                        mass[i] = rener;
                        Button5Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 6:
                        mass[i] = rener;
                        Button6Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 7:
                        mass[i] = rener;
                        Button7Exc.Background = Brushes.LightBlue;
                        await Task.Delay(250);
                        _clearAll();
                        break;
                    case 8:
                        mass[i] = rener;
                        Button8Exc.Background = Brushes.LightBlue;
                        await Task.Delay(100);
                        _clearAll();
                        break;
                    case 9:
                        mass[i] = rener;
                        Button9Exc.Background = Brushes.LightBlue;
                        await Task.Delay(100);
                        _clearAll();
                        break;
                }
                await Task.Delay(500);

            }
            _clearAll();
           for(int j = currentplaymass; j < currentround; j++)
            {
                MassBlock.Text += mass[j].ToString();
            }
            StartWaitLabel.Content = "";
            StartWaitLabel.Foreground = Brushes.LightGreen;
            StartWaitLabel.Content = "START";
            
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            _check();
        }
    }
}
