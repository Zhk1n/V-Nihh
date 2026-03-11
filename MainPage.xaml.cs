namespace TaskApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void AboutClicked(object sender, EventArgs e)
    {
        await DisplayAlert("About Us",
            "Task App created by the V-Nihh team.",
            "OK");
    }
}