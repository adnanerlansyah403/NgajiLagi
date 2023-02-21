namespace Ngaji.Pages;

using Pages.User;
public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    async void EditProfile_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new EditProfile());
    }

    async void ChangePassword_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChangePassword());
    }
}