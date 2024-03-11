using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using CanvasMauiClientBogdan.Services;
using CanvasMauiClientBogdan.ViewModels;
using CanvasMauiClientBogdan.Pages;
namespace CanvasMauiClientBogdan;


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

			
			
			var assembly = Assembly.GetExecutingAssembly();
string appsettingsFileName = "CanvasMauiClientBogdan.appsettings.json";
using (var stream = assembly.GetManifestResourceStream(appsettingsFileName))
{
if (stream != null)
{
builder.Configuration.AddJsonStream(stream);
}
}

//For groups
builder.Services.AddTransient<IGroupService, GroupService>();
builder.Services.AddTransient<GroupViewModel>();
builder.Services.AddSingleton<GroupPage>();
//For courses
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<CoursesViewModel>();
builder.Services.AddSingleton<CoursesPage>();



#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
