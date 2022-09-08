using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarCircleView : ContentView
	{
		public static BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CarCircleView), null);

		public CarCircleView ()
		{
			InitializeComponent ();
		}

		public ICommand Command
		{
			get { return (ICommand)this.GetValue(CommandProperty); }
			set { this.SetValue(CommandProperty, value); }
		}

		protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
		{
			var sizeRequest = base.OnMeasure(widthConstraint, heightConstraint);

			// automatically create round circle, even when size is changed
			_borderOuter.CornerRadius = (float)widthConstraint / 2;
			_borderInner.CornerRadius = (float)widthConstraint / 2;

			return sizeRequest;
		}

		private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
		{
			Command?.Execute(null);
		}
	}
}