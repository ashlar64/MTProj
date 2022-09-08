using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamurai
{
	public class CarDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate CarView { get; set; }
		public DataTemplate MercedesView { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			return ((Car)item).Make == CarMake.Mercedes ? MercedesView : CarView;
		}
	}
}
