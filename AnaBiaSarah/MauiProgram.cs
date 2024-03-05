using Microsoft.Extensions.Logging;

namespace AnaBiaSarah;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("White Night Club.ttf", "White Night Club");
				fonts.AddFont("White Night Club.ttf", "White Night Club");
				fonts.AddFont("White Night Club.ttf", "White Night Club");
				fonts.AddFont("Boldena.ttf", "Boldena");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

