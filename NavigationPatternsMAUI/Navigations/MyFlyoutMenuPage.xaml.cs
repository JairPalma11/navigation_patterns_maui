using NavigationPatternsMAUI.Models;
using NavigationPatternsMAUI.Pages;

namespace NavigationPatternsMAUI.Navigations;

public partial class MyFlyoutMenuPage : ContentPage
{
    public MyFlyoutMenuPage()
	{
		InitializeComponent();

		var items = new List<FlyoutItemModel>();

		//agregamos al menu cada uno de las paginas
		var contact = new FlyoutItemModel
		{
			Title = "Contacto",
			ImageUrl = "call_icon",
			PageType = typeof(ContactPage)
		};

		items.Add(contact);

        var profile = new FlyoutItemModel
        {
            Title = "Mi Perfil",
            ImageUrl = "person_icon",
            PageType = typeof(ProfilePage)
        };

        items.Add(profile);


        var about = new FlyoutItemModel
        {
            Title = "Acerca",
            ImageUrl = "info_icon",
            PageType = typeof(AboutPage)
        };

        items.Add(about);

       // collectionView.ItemsSource = items;
    }
}
