using System.Windows;

namespace ToDoApp
{
    public partial class AddTaskWindow : Window
    {
        public Task NewTask { get; set; }

        public AddTaskWindow()
        {
            InitializeComponent();
            NewTask = new Task();
            DataContext = this;
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
