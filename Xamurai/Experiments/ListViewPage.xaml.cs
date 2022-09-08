using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		private SampleViewModel _vm = null;

		public ListViewPage ()
		{
			_vm = new SampleViewModel();
			BindingContext = _vm;
			InitializeComponent ();

			MessagingCenter.Subscribe<Car>(this, Hardcoded.MESSAGE_DELETECAR, (sender) =>
			{
				DeleteCar(sender);
			});
		}

		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height);

			carCarouselView1.ItemsLayout = (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Portrait)
				? new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
				: new LinearItemsLayout(ItemsLayoutOrientation.Horizontal);
		}

		void DeleteCar_Clicked(System.Object sender, System.EventArgs e)
		{
			var contentView = sender as SwipeItem;
			var car = contentView.BindingContext as Car;
			DeleteCar(car);
		}

		private void DeleteCar(Car car)
		{
			if(car == null)
			{
				// log this
				return;
			}

			if (_vm.Cars.Any())
			{
				if(car.Abbreviation == null)
				{
					_vm.Cars.Remove((Car)carCarouselView1.SelectedItem);
				}
				else
				{
					_vm.Cars.Remove(car);
				}
				//carCarouselView1.ItemsSource = _vm.Cars;
				// strange bug need to do this hack
				carCarouselView1.ItemsSource = new ObservableCollection<Car>(_vm.Cars);
			}
		}
	}
}