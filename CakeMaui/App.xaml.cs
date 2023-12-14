using CakeMaui.Views;

namespace cakeMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new OfficialListPage())
        {
            BarTextColor = Color.FromRgb(255, 255, 255)
        };
    }
}
