using Prism.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamurai
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			OpenListViewCommand = new DelegateCommand(OpenListView);
			OpenCollectionViewCommand = new DelegateCommand(OpenCollectionView);
			OpenCarouselViewCommand = new DelegateCommand(OpenCarouselView);
			OpenFlexLayoutViewCommand = new DelegateCommand(OpenFlexLayoutView);
			OpenPagedCollectionViewCommand = new DelegateCommand(OpenPagedCollectionView);

			BindingContext = this;
			InitializeComponent();
		}

		public ICommand OpenListViewCommand { get; }

		public ICommand OpenCollectionViewCommand { get; }

		public ICommand OpenCarouselViewCommand { get; }

		public ICommand OpenPagedCollectionViewCommand { get; }

		public ICommand OpenFlexLayoutViewCommand { get; }

		private void OpenListView()
		{
			Navigation.PushAsync(new ListViewPage());
		}

		private void OpenCollectionView()
		{
			Navigation.PushAsync(new CollectionViewPage());
		}

		private void OpenCarouselView()
		{
			Navigation.PushAsync(new CarouselViewPage());
		}

		private void OpenFlexLayoutView()
		{
			Navigation.PushAsync(new FlexLayoutPage());
		}

		private void OpenPagedCollectionView()
		{
			Navigation.PushAsync(new PagedCollectionPage());
		}


	}
}
