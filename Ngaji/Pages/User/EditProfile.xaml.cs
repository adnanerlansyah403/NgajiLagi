namespace Ngaji.Pages.User;

public partial class EditProfile : ContentPage
{
	public EditProfile()
	{
		InitializeComponent();
	}

    async void Goback_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}