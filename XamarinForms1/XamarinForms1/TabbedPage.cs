using System;

using Xamarin.Forms;

namespace XamarinForms1
{
	public class TabbedPage : Xamarin.Forms.TabbedPage
	{
		public TabbedPage ()
		{


			this.Title = "TabbedPage";

			this.Children.Add(new SingleTappedPage(0));
			this.Children.Add(new SingleTappedPage(1));
			this.Children.Add(new SingleTappedPage(2));
			this.Children.Add(new SingleTappedPage(3));



		}
	}
}


