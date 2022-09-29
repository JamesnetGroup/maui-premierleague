namespace PremierApp.Pages;

public partial class Tables : ContentPage
{
	public Tables()
	{
		InitializeComponent();

		BindingContext = new TablesViewModel();
	}
}
