using NavigationPatternsMAUI.Models;

namespace NavigationPatternsMAUI.Navigations;

public partial class MyFlyoutPage : FlyoutPage
{
	public MyFlyoutPage()
	{
		InitializeComponent();
        myFlyoutMenuPage.collectionView.SelectionChanged += OnSelectionChanged;
    }

    void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //este codigo es para mostrar
        //la pagina en el detalle
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutItemModel;
        if (item != null)
        {
            //creamos la pagina que se especifico
            // en nuestro modelo FlyoutItemModel.PageType
            //mediante reflection creamos la pagina
            var page = (Page)Activator.CreateInstance(item.PageType);
            //asignamos la pagina al Detail de nuestro FlyoutPage
            //esto con el fin de tener una navegacion stack si se requiere.
            //sino se puede asignar directamente al Detail
            //de la siguiente manera, Detail = page;
            Detail = new NavigationPage(page);
            var flyoutController = (IFlyoutPageController)this;
            //permite identificar cuando necesitamos cerrar el
            //detalle despues de seleccionar nuestra pagina.
            //sino queda abierto y puede obstaculizar la vista
            //al usuario.
            if (!flyoutController.ShouldShowSplitMode)
            {
                IsPresented = false;
            }
        }
    }
}
