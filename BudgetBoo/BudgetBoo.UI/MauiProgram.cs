using Microsoft.Extensions.Logging;

namespace BudgetBoo.UI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("RobotoMono-Bold.ttf", "RobotoMonoBold");
				fonts.AddFont("RobotoMono-Regular.ttf", "RobotoMonoRegular");
            });

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "BudgetBoo.db");
        builder.Services.AddSingleton(_ => dbPath);

        builder.Services.AddSingleton<App>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
