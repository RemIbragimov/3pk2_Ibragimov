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

namespace pz_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Caretaker caretaker = new Caretaker();
        private Originator originator = new Originator();
        private int currentVersion = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, RoutedEventArgs e)
        {
            originator.Text = textBox.Text;
            caretaker.Add(originator.Save());
            currentVersion = caretaker.GetVersionsCount() - 1;
            UpdateStatusText();
        }

        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentVersion > 0)
            {
                currentVersion--;
                originator.Restore(caretaker.Get(currentVersion));
                textBox.Text = originator.Text;
                UpdateStatusText();
            }
        }

        private void redoButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentVersion < caretaker.GetVersionsCount() - 1)
            {
                currentVersion++;
                originator.Restore(caretaker.Get(currentVersion));
                textBox.Text = originator.Text;
                UpdateStatusText();
            }
        }

        private void UpdateStatusText()
        {
            statusText.Text = $"Значений {currentVersion + 1} из {caretaker.GetVersionsCount()}";
        }
    }

    public class Originator
    {
        public string Text { get; set; }

        public Memento Save()
        {
            return new Memento(Text);
        }

        public void Restore(Memento memento)
        {
            Text = memento.Text;
        }
    }

    public class Memento
    {
        public string Text { get; }

        public Memento(string text)
        {
            Text = text;
        }
    }

    public class Caretaker
    {
        private List<Memento> versions = new List<Memento>();

        public void Add(Memento memento)
        {
            versions.Add(memento);
        }

        public Memento Get(int index)
        {
            return versions[index];
        }

        public int GetVersionsCount()
        {
            return versions.Count;
        }
    }
}
