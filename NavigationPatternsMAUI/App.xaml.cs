using NavigationPatternsMAUI.Navigations;

namespace NavigationPatternsMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //NavigationPage tiene que ser el main
        MainPage = new NavigationPage(new StackNavigationPage());
	}
}

