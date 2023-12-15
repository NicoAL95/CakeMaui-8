using CakeMaui.Views;

namespace CakeMaui.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

	async void ButtonStart(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OfficialListPage());
    }
}