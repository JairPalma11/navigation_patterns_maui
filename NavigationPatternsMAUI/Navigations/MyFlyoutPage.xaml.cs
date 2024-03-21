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
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutItemModel;
        if (item != null)
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
            if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                IsPresented = false;
        }
    }
}
