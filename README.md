    <Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
       xmlns:views="clr-namespace:MauiApp1"
       x:Class="MauiApp1.AppShell">
        <TabBar>
            <Tab Title="Menu"
            Icon="hambargambar.png">
                <ShellContent ContentTemplate="{DataTemplate views:MainPage}" />
            </Tab>
            <Tab Title="Home"
            Icon="home.png">
                <ShellContent ContentTemplate="{DataTemplate views:MainPage}" />
            </Tab>
        </TabBar>
    </Shell>

tite
