namespace PremierApp.Pages;

public partial class Results : ContentPage
{
	public Results()
	{
		InitializeComponent();

		BindingContext = new ResultsViewModel();
	}
}
