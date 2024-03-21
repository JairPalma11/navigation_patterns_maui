using NavigationPatternsMAUI.Navigations;

namespace NavigationPatternsMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //Ejemplo de Tab Page
        MainPage = new MyTabbedPage();

        //Ejemplo de navigation Page
        //MainPage = new NavigationPage(new StackNavigationPage());

        //Ejemplo de una sola pantalla
        //MainPage = new SimpleNavigationPage();

        //Ejemplo de flyout
        //MainPage = new MyFlyoutPage();
    }

    protected override void OnStart()
    {
        base.OnStart();
        Console.WriteLine("Se ejecuto OnStart una sola vez cuando inicia la App");
    }

    protected override void OnResume()
    {
        base.OnResume();
        Console.WriteLine("Se ejecuto OnResume cuando la aplicacion esta al frente.");
    }

    protected override void OnSleep()
    {
        base.OnSleep();
        Console.WriteLine("Se ejecuto OnSleep cuando la aplicacion NO esta al frente.");
    }
}

