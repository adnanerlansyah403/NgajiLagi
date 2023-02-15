namespace ngajilagi.Views.Payment;

using CommunityToolkit.Maui.Views;

public partial class PaymentMethodPage : ContentPage
{

	public PaymentMethodPage()
	{
		InitializeComponent();

        var expander = new Expander
        {
            Header = new Label
            {
                Text = "Baboon",
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            }
        };

        expander.Content = new HorizontalStackLayout
            {
            Padding = new Thickness(10),

            Children =
            {
                new Image
                {
                    Source = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
                    Aspect = Aspect.AspectFill,
                    HeightRequest = 120,
                    WidthRequest = 120
                },

                new Label
                {
                    Text = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                    FontAttributes = FontAttributes.Italic
                }
            }
        };

    }

    private bool _statusTransferVA = false;
    async void TapTransferVA(object sender, TappedEventArgs e)
    {
        await toggleTransferVA.RotateTo(_statusTransferVA ? 0 : 90);

        _statusTransferVA = !_statusTransferVA;
    }

    private bool _statusTunaiGerai = false;
    async void TapTunaiGerai(object sender, TappedEventArgs e)
    {
        await toggleTunaiGerai.RotateTo(_statusTunaiGerai ? 0 : 90);

        _statusTunaiGerai = !_statusTunaiGerai;
    }
}

