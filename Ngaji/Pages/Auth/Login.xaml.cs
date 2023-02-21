namespace Ngaji.Pages.Auth;

using Ngaji.Pages.Book;
using Ngaji.Pages;
using System.Windows.Input;
using Ngaji.Pages.Auth.Register;

public partial class Login : ContentPage
{

    public Login()
	{
		InitializeComponent();
	}

    private async void GotoLupaPassword(object sender, EventArgs e)
    {
        // await Launcher.Default.OpenAsync("https://aka.ms/maui");
        await Navigation.PushAsync(new LupaPassword());

        // Application.Current.MainPage = new Microsoft.Maui.Controls.NavigationPage(new LupaPassword());
    }

    private async void GotoMainPage(object sender, EventArgs e)
    {
        //Application.Current.MainPage = new NavigationPage(new LandingPage());
        await Navigation.PopAsync();
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppShell());
    }

    private async void Register_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChooseTarget());
        var existingPages = Navigation.NavigationStack.ToList();
        foreach (var page in existingPages)
        {
            if (page != null)
            {
                Navigation.RemovePage(page);
            }
        }
        // Navigation.InsertPageBefore(new ChooseTarget(), Navigation.NavigationStack[0]);
    }
}