using System;

namespace AddanewTask;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnDoneClicked(object sender, EventArgs e)
    {
        string taskName = TaskNameEntry.Text;

        if (string.IsNullOrWhiteSpace(taskName))
        {
            await DisplayAlertAsync("Error!", "Enter a Task Name", "OK");
            return;
        }

        await DisplayAlertAsync("Progress", $"Task '{taskName}' has been added!", "OK");

        TaskNameEntry.Text = string.Empty;
    }
}