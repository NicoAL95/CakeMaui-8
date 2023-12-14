namespace CakeMaui.Views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CakeMaui.Data;
using CakeMaui.Models;
public partial class OfficialListPage : ContentPage
{
    public OfficialListPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        OfficialFormDatabase database = await OfficialFormDatabase.Instance;
        listView.ItemsSource = await database.GetItemsAsync();
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OfficialFormPage
        {
            BindingContext = new OfficialForm()
        });
    }

    async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new OfficialFormPage
            {
                BindingContext = e.SelectedItem as OfficialForm
            });
        }
    }
}