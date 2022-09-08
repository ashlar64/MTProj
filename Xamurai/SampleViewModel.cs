using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Aud = Acr.UserDialogs;

namespace Xamurai
{
	public class SampleViewModel : BindableBase
	{
		protected Aud.IUserDialogs Dialogs { get; }

		public SampleViewModel()
		{
			Dialogs = Aud.UserDialogs.Instance;
			GridSpan = Device.Idiom == TargetIdiom.Phone ? 1 : 2;
			BuildCars();
		}

		private int _gridSpan;

		public int GridSpan
		{
			get { return _gridSpan; }
			set { SetProperty(ref _gridSpan, value); }
		}

		private void BuildCars()
		{
			Cars = new ObservableCollection<Car>
			{
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo0", Notes = "test car", Description = "Some description", Color = Color.Black },
				new Car { Abbreviation = "BMW", Make=CarMake.BMW, Name = "X5", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 10)), Color = Color.Purple },
				new Car { Abbreviation = "M", Make=CarMake.Mercedes, Name = "AMG C Class", Notes = "Mercedes car", Description = string.Concat(Enumerable.Repeat($"Some description Mercedes {Environment.NewLine}", 5)), Color = Color.CornflowerBlue},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo1", Description = "Some description", Color = Color.Brown },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo2", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.Orange },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo3", Description = "Some description", Color = Color.DarkBlue },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo4", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 7)), Color = Color.DarkOrange },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo5", Description = "Some description", Color = Color.OrangeRed },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo6", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 4)), Color = Color.Violet},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo7", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 2)), Color = Color.DarkSalmon },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo8", Description = "Some description", Color = Color.Green },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo0", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 6)), Color = Color.GreenYellow},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo10", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.LawnGreen},
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo11", Description = "Some description", Color = Color.SkyBlue },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo12", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.LightCyan },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo13", Description = "Some description", Color = Color.PaleTurquoise },
				new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo14", Description = "Some description", Color = Color.Purple },
			};
		}

		private ObservableCollection<Car> _cars;

		public ObservableCollection<Car> Cars
		{
			get { return _cars; }
			set { SetProperty(ref _cars, value); }
		}
	}
}
