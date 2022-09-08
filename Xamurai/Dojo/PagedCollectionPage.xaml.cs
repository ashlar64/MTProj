
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagedCollectionPage : ContentPage
	{
		public PagedCollectionPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}
	}
}