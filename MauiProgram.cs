using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace ngajilagi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Nunito-Regular.ttf", "NunitoRegular");
				fonts.AddFont("Nunito-Bold.ttf", "NunitoBold");
			});
        builder.UseMauiCommunityToolkit();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
