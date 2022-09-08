using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("OpenSansExtraBoldItalic.ttf", Alias = "OpenSans")]
[assembly: ExportFont("OpenSansRegular.ttf", Alias = "OpenSans")]
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamurai
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
