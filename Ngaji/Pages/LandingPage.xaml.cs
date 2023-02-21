using Ngaji.Pages.Auth;
using Ngaji.ViewModels;

namespace Ngaji.Pages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
        BindingContext = new UstadzsViewModel();
    }

    private async void GotoLogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
}