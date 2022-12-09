using Gesca.ViewModel;

namespace Gesca;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton<loginPage>();
        builder.Services.AddSingleton<loginViewModel>();

        builder.Services.AddTransient<cashierHome>();
		builder.Services.AddTransient<CashierViewModel>();
		return builder.Build();
	}
}
