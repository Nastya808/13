using System.Collections.ObjectModel;
using System.Windows;

namespace ToDoApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Task> Tasks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<Task>();
            DataContext = this;
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var addTaskWindow = new AddTaskWindow();
            addTaskWindow.Owner = this;

            if (addTaskWindow.ShowDialog() == true)
            {
                Tasks.Add(addTaskWindow.NewTask);
            }
        }

        private void ChangeStatusButton_Click(object sender, RoutedEventArgs e)
        {
            if (tasksListBox.SelectedItem is Task selectedTask)
            {
                selectedTask.IsCompleted = !selectedTask.IsCompleted;
            }
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (tasksListBox.SelectedItem is Task selectedTask)
            {
                Tasks.Remove(selectedTask);
            }
        }
    }
}
