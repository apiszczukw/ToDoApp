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

            BindingContext = this;
        }

       
    }

}
