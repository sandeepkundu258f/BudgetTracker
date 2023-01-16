using Microsoft.Maui.Controls;

namespace BudgetTracker.UI.Pages;

public partial class OverviewPage : ContentPage
{
	public OverviewPage()
    {
        InitializeComponent();

        var _ToolbarItems = this.ToolbarItems;
    }

    private async void SettingsTbi_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SettingsPage");
    }
}