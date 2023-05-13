using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pz_11
{
    public class ViewModel : ICommand, INotifyPropertyChanged
    {
        private Model model;
        private View view;
        private ObservableCollection<Book> books;

        public ViewModel(Model model, View view)
        {
            this.model = model;
            this.view = view;
            this.books = new ObservableCollection<Book>();
            this.view.ListViewBooks.ItemsSource = this.books;
            this.view.ButtonSave.Command = this;
        }

        public bool CanExecute(object parameter)
        {
            // Проверка возможности выполнения команды
            return true;
        }

        public void Execute(object parameter)
        {
            // Выполнение команды
            if (parameter.ToString() == "SaveToJSON")
            {
                model.SaveToJSON();
            }
        }

        public event EventHandler CanExecuteChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddBook()
        {
            Book book = new Book(view.TextBookName, view.TextAuthor, int.Parse(view.TextYear));
            books.Add(book);
        }
    }
}
