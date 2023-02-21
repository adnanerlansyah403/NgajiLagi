namespace Ngaji;

using Ngaji.Pages.Book;
using Ngaji.Pages.Auth;
using Ngaji.Pages.Auth.Register;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("auth/login", typeof(Login));
    }
}
