namespace UthingoMauiApp;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped_For_Login(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Login");
	}
}