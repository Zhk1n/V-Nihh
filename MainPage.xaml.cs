using System.Collections.ObjectModel;

namespace TaskApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        var taskList = new List<TaskItem>
        {
            new TaskItem { TaskName = "Laundry", IsCompleted = false },
            new TaskItem { TaskName = "Pack Bags", IsCompleted = false },
            new TaskItem { TaskName = "Cut grass", IsCompleted = false },
        };
    }
}

public class TaskItem
{
    public string TaskName { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}