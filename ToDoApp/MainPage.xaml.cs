using System.Collections.ObjectModel;
using ToDoApp.Models;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ToDoTask> TasksList => ToDoTaskManager.Tasks;

        public MainPage()
        {
            InitializeComponent();

            ToDoTaskManager.AddTestData();

            ToDoTaskManager.LoadTasks();

            BindingContext = this;
        }

        private void Done_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            ToDoTaskManager.SaveTasks();
        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            if(sender is Button button && button.BindingContext is ToDoTask task && TasksList.Contains(task))
            {
                TasksList.Remove(task);
                ToDoTaskManager.SaveTasks();
            }
        }
    }

}
