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
        string[] tasks = new string[3];
        public MainWindow()
        {
            InitializeComponent();
            tasks[0] = "Зробити ДЗ по 4 лекції";
            tasks[1] = "Прочитати 10 ст";
            tasks[2] = "Медитація";

            ToDoListBox.ItemsSource = tasks;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToDoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }

}
