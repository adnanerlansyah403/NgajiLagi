namespace Ngaji.Pages.User;

public partial class ChangePassword : ContentPage
{
	public ChangePassword()
	{
		InitializeComponent();
	}

    async void Goback_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}