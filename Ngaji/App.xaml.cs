using Ngaji.Pages;
using Ngaji.Pages.Auth;
using Ngaji.Pages.Auth.Register;
using Ngaji.Pages.Book;

namespace Ngaji;

public partial class App : Application
{
	public App()
	{
        InitializeComponent();

        MainPage = new AppShell();
        // MainPage = new Microsoft.Maui.Controls.NavigationPage(new ChooseTarget());
    }
}
