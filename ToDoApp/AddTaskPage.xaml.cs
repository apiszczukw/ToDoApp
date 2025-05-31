using ToDoApp.Models;

namespace ToDoApp;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
		InitializeComponent();
	}

	private async void SaveBtn_Clicked(object sender, EventArgs e)
	{
		ToDoTaskManager.AddNewTask(TitleTxt.Text, DetailsTxt.Text);

		await DisplayAlert("Sukces", "Nowe zadanie dodane!", "OK");

		await Shell.Current.GoToAsync("//MainPage");
	}
}