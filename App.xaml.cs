namespace CanvasMauiClientBogdan;
using CanvasMauiClientBogdan.Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
