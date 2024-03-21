namespace NavigationPatternsMAUI.Navigations;

public partial class StackNavigationPage : ContentPage
{
	public StackNavigationPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new StackDetailNavigationPage());
    }
}
