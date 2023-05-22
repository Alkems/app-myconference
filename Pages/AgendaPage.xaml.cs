namespace app_myconference.Pages;

public partial class AgendaPage : ContentPage
{
	public AgendaPage(AgendaDay1ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}