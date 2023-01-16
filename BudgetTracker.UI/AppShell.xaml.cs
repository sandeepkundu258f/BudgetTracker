using BudgetTracker.UI.Pages;

namespace BudgetTracker.UI;

public partial class AppShell : Shell
{
   
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));

    }

    private async void SettingsTbi_Clicked(object sender, EventArgs e)
    {
        //this.ToolbarItems.Clear();
        await Current.GoToAsync("SettingsPage");
    }
}
