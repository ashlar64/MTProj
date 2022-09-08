using Prism.Commands;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;
using Xamarin.Essentials;
using Aud = Acr.UserDialogs;
using Xamarin.CommunityToolkit.Markup;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MercedesView : ContentView, INotifyPropertyChanged
	{
		protected Aud.IUserDialogs Dialogs { get; }
		public bool IsExpanded { get; set; }
		public ICommand ToggleCollapseCommand { get; }
		public ICommand LongPressCommand { get; }
		private double _itemSize;

		public MercedesView ()
		{
			IsExpanded = true;
			Dialogs = Aud.UserDialogs.Instance;
			ToggleCollapseCommand = new Command(async () => await ToggleCollapse());
			LongPressCommand = new Command(async () => await LongPress());
			InitializeComponent ();
		}

		protected override void OnSizeAllocated(double width, double height)
		{
			base.OnSizeAllocated(width, height);
			longPressedGrid.IsVisible = DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape;
		}

		private async Task ToggleCollapse()
		{
			IsExpanded = !IsExpanded;

			if(IsExpanded)
			{
				OnPropertyChanged(nameof(IsExpanded));
				Content.HeightRequest = _itemSize;
				var an3 = notesLabel.FadeTo(1, 450, Easing.Linear);
				var an4 = notesLabel.ScaleTo(1, 1000, Easing.BounceOut);
				var ad3 = descriptionLabel.FadeTo(1, 450, Easing.Linear);
				var ad4 = descriptionLabel.ScaleTo(1.0, 1000, Easing.BounceOut);

				await Task.WhenAll(an3, an4, ad3, ad4);
			}
			else
			{
				_itemSize = Content.Height;
				var an1 = notesLabel.FadeTo(.2, 1000, Easing.Linear);
				var an2 = notesLabel.ScaleTo(.2, 1000, Easing.BounceIn);
				var ad1 = descriptionLabel.FadeTo(.2, 1000, Easing.Linear);
				var ad2 = descriptionLabel.ScaleTo(.2, 1000, Easing.BounceIn);

				await Task.WhenAll(an1, an2, ad1, ad2);
				Content.HeightRequest = 65.0;

				OnPropertyChanged(nameof(IsExpanded));
			}
		}

		private async Task LongPress()
		{
			if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
			{
				bool result = await Dialogs.ConfirmAsync("Are you sure you want to delete this car?", "Delete Car", Hardcoded.Yes, Hardcoded.No);

				if (result)
				{
					MessagingCenter.Send<string>("", Hardcoded.MESSAGE_DELETECAR);
				}
			}
		}
	}
}