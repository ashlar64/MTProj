using Prism.Mvvm;
using Xamarin.Forms;

namespace Xamurai
{
	public class Car : BindableBase
	{
		private string _abbreviation;

		public string Abbreviation
		{
			get { return _abbreviation; }
			set { SetProperty(ref _abbreviation, value); }
		}

		private CarMake _make;

		public CarMake Make
		{
			get { return _make; }
			set { SetProperty(ref _make, value); }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { SetProperty(ref _name, value); }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { SetProperty(ref _description, value); }
		}

		private string _notes;

		public string Notes
		{
			get { return _notes; }
			set { SetProperty(ref _notes, value); }
		}

		private Color _color;

		public Color Color
		{
			get { return _color; }
			set { SetProperty(ref _color, value); }
		}

		private bool _fullView;

		public bool FullView
		{
			get { return _fullView; }
			set
			{
				SetProperty(ref _fullView, value);
			}
		}

		public bool IsMercedes
		{
			get
			{
				return Make == CarMake.Mercedes;
			}
		}
	}

	public enum CarMake
	{
		VolksWagen,
		Mercedes,
		BMW
	}
}
