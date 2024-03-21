using NavigationPatternsMAUI.Navigations;

namespace NavigationPatternsMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new SimpleNavigationPage();
	}
}

