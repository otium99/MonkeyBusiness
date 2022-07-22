using MonkeyBusiness.View;
using MonkeyBusiness.ViewModel;

namespace MonkeyBusiness;

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

        builder.Services.AddTransient<VerticalStackLayoutPage>();
        builder.Services.AddTransient<VerticalStackLayoutViewModel>();

        return builder.Build();
	}
}
