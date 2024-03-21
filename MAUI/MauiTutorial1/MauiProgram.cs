using MauiTutorial1.Services;
using MauiTutorial1.ViewModels;
using Microsoft.Extensions.Logging;
using System;

namespace MauiTutorial1
{
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

            builder.Services.AddSingleton<INewsService, NewsService>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<ViewModel>();
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
