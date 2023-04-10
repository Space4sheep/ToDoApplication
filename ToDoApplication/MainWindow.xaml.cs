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

namespace ToDoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Task> tasksList = new List<Task>();
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
    }

}
