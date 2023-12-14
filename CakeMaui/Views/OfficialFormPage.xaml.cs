namespace CakeMaui.Views;
using CakeMaui.Models;
using CakeMaui.Data;
public partial class OfficialFormPage : ContentPage
{
    public OfficialFormPage()
	{
		InitializeComponent();

        datePicker.MinimumDate = DateTime.Today;
    }
    async void OnSaveClicked1(object sender, EventArgs e)
    {
        var OfficialForm = (OfficialForm)BindingContext;
        OfficialFormDatabase database = await OfficialFormDatabase.Instance;
        await database.SaveItemAsync(OfficialForm);
        await Navigation.PopAsync();
    }

    async void OnDeleteClicked1(object sender, EventArgs e)
    {
        var OfficialForm = (OfficialForm)BindingContext;
        OfficialFormDatabase database = await OfficialFormDatabase.Instance;
        await database.DeleteItemAsync(OfficialForm);
        await Navigation.PopAsync();
    }

    async void OnCancelClicked1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}