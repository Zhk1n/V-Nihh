MainPage.xaml

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            x:Class="TaskApp.MainPage"
            BackgroundColor="White">
   
    
    <Grid RowDefinitions="Auto, *, 70">
        
        <Grid Grid.Row="0" ColumnDefinitions="*, Auto" Padding="20, 40, 20, 10">
            <Label Text="Tasks" FontSize="32" FontAttributes="Bold" VerticalOptions="Center" />
            <Button Grid.Column="1" Text="+" FontSize="24" CornerRadius="25" HeightRequest="50" WidthRequest="50" BackgroundColor="#E0E0E0" TextColor="Black"/>
        </Grid>
        <ScrollView Grid.Row="1" Padding="10">
            <CollectionView x:Name="TasksCollection" ItemsLayout="VerticalGrid, 2">
                <CollectionView.ItemTemplate>
                    <DataTemplate>
                        <Frame Margin="5" BorderColor="Black" CornerRadius="0" Padding="10" HeightRequest="100">
                            <HorizontalStackLayout Spacing="10">
                                <CheckBox IsChecked="{Binding IsCompleted}" Color="Black" />
                                <Label Text="{Binding TaskName}" VerticalOptions="Center" FontSize="16" />
                            </HorizontalStackLayout>
                        </Frame>
                    </DataTemplate>
                </CollectionView.ItemTemplate>
            </CollectionView>
        </ScrollView>
        <Grid Grid.Row="2" ColumnDefinitions="*, *, *" BackgroundColor="#F5F5F5">
            
            <VerticalStackLayout Grid.Column="0" VerticalOptions="Center">
                
                <Label Text="≡" FontSize="24" HorizontalOptions="Center"/>
                
            </VerticalStackLayout>
            
            <VerticalStackLayout Grid.Column="1" VerticalOptions="Center">
                <Label Text="⌂" FontSize="24" HorizontalOptions="Center"/>
                <Label Text="Home" FontSize="12" HorizontalOptions="Center"/>
            </VerticalStackLayout>
            
            <VerticalStackLayout Grid.Column="2" VerticalOptions="Center">
                <Label Text="⚙" FontSize="20" HorizontalOptions="Center"/>
                <Label Text="Settings" FontSize="12" HorizontalOptions="Center"/>
            </VerticalStackLayout>







namespace TaskApp;

public partial class MainPage : ContentPage

{
    public MainPage()
    {
        InitializeComponent();
        var taskList = new List<TaskItem>

        {
            new TaskItem { TaskName = "Laundry", IsCompleted = false },
            new TaskItem { TaskName = "Pack Bags", IsCompleted = false },
            new TaskItem { TaskName = "Cut grass", IsCompleted = false },
        };
        TasksCollection.ItemsSource = taskList;
    }
}

public class TaskItem

{

    public string TaskName { get; set; }
    public bool IsCompleted { get; set; }

}






            
            
        </Grid>
    </Grid>
</ContentPage>
