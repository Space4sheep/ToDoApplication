using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ToDoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Task> tasksList = new ObservableCollection<Task>();
        public MainWindow()
        {
            InitializeComponent();

            Task t1 = new Task();
            t1.Name = "Зробити ДЗ по 4 лекції";
            t1.IsCompleted = false;
            t1.Description = "Марафон С#";

            Task t2 = new Task();
            t2.Name = "Прочитати 10 ст";
            t2.IsCompleted = false;
            t2.Description = "Книга на вибір";

            Task t3 = new Task();
            t3.Name = "Медитація";
            t3.IsCompleted = false;
            t3.Description = "";

            tasksList.Add(t1);
            tasksList.Add(t2);
            tasksList.Add(t3);


            ToDoListBox.ItemsSource = tasksList;
            ToDoListBox.DisplayMemberPath = "Name";
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToDoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ToDoListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Task selected = ToDoListBox.SelectedItem as Task;
            if (selected != null)
            {
                MessageBox.Show(selected.Description);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewTaskWindow window = new NewTaskWindow();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            if(window.ShowDialog() == true)
            {
                Task newTask = window.Result;
                tasksList.Add(newTask);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ToDoListBox.SelectedIndex;
            if (index != -1)
            {
                tasksList.RemoveAt(index);
            }
        }

        private void ComplateButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ToDoListBox.SelectedIndex;
            if (index != -1)
            {
                tasksList[index].IsCompleted = true;
            }
        }

        private void AllRadiButton_Checked(object sender, RoutedEventArgs e)
        {
            ToDoListBox.ItemsSource = tasksList;
        }

        private void NotCompetedRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Task> filtered = new ObservableCollection<Task>();
            for (int i = 0; i < tasksList.Count; i++)
            {
                Task current = tasksList[i];
                if (current.IsCompleted == false)
                {
                    filtered.Add(current);
                }
                ToDoListBox.ItemsSource = filtered;
            }
        }

        private void CompletedRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Task> filtered = new ObservableCollection<Task>();
            for (int i = 0; i < tasksList.Count; i++)
            {
                Task current = tasksList[i];
                if (current.IsCompleted == true)
                {
                    filtered.Add(current);
                }
                ToDoListBox.ItemsSource = filtered;
            }
        }
    }

}
