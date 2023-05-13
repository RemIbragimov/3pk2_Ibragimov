using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace pz_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // создаем список объектов класса Book
        List<Book> books = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();

            // загружаем данные из файла при запуске приложения
            LoadData();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            // запрашиваем у пользователя данные о книгах и добавляем их в список
            while (true)
            {
                string title = Microsoft.VisualBasic.Interaction.InputBox("Введите название книги (или введите 'exit' для выхода):", "Add Book");
                if (title == "exit")
                    break;

                string author = Microsoft.VisualBasic.Interaction.InputBox("Введите автора книги:", "Add Book");

                int year;
                while (!int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Введите год публикации:", "Add Book"), out year))
                {
                    MessageBox.Show("Введите корректный год.");
                }

                books.Add(new Book(title, author, year));
            }

            // сохраняем данные в файл и обновляем список
            SaveData();
            LoadData();
        }
        private void SaveData()
        {
            // сериализуем список объектов в строку JSON
            string json = JsonConvert.SerializeObject(books);

            // сохраняем строку JSON в файл
            File.WriteAllText("books.json", json);
        }

        private void LoadData()
        {
            try
            {
                // загружаем строку JSON из файла
                string jsonFromFile = File.ReadAllText("books.json");
                // десериализуем строку JSON в список объектов
                books = JsonConvert.DeserializeObject<List<Book>>(jsonFromFile);
                // очищаем список и добавляем загруженные данные
                MyListView.Items.Clear();
                foreach (var book in books)
                {
                    MyListView.Items.Add(string.Format("{0} автора {1}, вышла {2}", book.Title, book.Author, book.Year));

                }
            }
            catch
            {
                MessageBox.Show("GOOD");
            }
        }
    }
}

