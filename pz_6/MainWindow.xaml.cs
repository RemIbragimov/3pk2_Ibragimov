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

namespace pz_6
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

        private void StartLongCalculation_Click(object sender, RoutedEventArgs e)
        {
            // Вызываем метод LongCalculationAsync() асинхронно и передаем ему ProgressBar для отображения прогресса
            _ = LongCalculationAsync(Progress);
        }

        // Метод, производящий длительные вычисления в цикле
        private void LongCalculation()
        {
            for (int i = 0; i < 100; i++)
            {
                // Имитируем длительные вычисления
                System.Threading.Thread.Sleep(500);

                // Обновляем ProgressBar
                Progress.Dispatcher.Invoke(() => { Progress.Value = i + 1; });
            }
        }

        // Асинхронная обертка для метода LongCalculation()
        private async Task LongCalculationAsync(ProgressBar progressBar)
        {
            // Обнуляем ProgressBar
            progressBar.Dispatcher.Invoke(() => { progressBar.Value = 0; });

            // Вызываем метод LongCalculation() в отдельном потоке
            await Task.Run(() => LongCalculation());

            // Уведомляем пользователя об окончании вычислений
            MessageBox.Show("Длительный расчет завершен!");
        }
    }
}

//Выводы:
//1. Использование асинхронного программирования позволяет избежать блокировки интерфейса,
//приложения во время выполнения длительных операций и сохранить отзывчивость пользовательского интерфейса.
//2. Для выполнения длительных операций в отдельном потоке можно использовать метод Task.Run() вместе с ключевым словом async и await.
