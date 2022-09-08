
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CollectionViewPage : ContentPage
	{
		public CollectionViewPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}
	}
}