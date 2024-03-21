using NavigationPatternsMAUI.Navigations;

namespace NavigationPatternsMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //Ejemplo de Tab Page
        //MainPage = new MyTabbedPage();

        //Ejemplo de navigation Page
        //MainPage = new NavigationPage(new StackNavigationPage());

        //Ejemplo de una sola pantalla
        //MainPage = new SimpleNavigationPage();

        //Ejemplo de flyout
        MainPage = new MyFlyoutPage();
    }
}

