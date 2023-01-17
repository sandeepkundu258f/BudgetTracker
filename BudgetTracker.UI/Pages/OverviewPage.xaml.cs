using Microsoft.Maui.Controls;

namespace BudgetTracker.UI.Pages;

public partial class OverviewPage : ContentPage
{
	public OverviewPage()
    {
        InitializeComponent();

        var _ToolbarItems = this.ToolbarItems;
    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    InitializeComponent();
    //}

    private async void SettingsTbi_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SettingsPage");
    }

    private void ExitTbi_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}