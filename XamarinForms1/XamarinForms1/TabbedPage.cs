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

//			this.Children.Add (new ContentPage {
//				Title = "Yellow",
//
//				Content = new StackLayout {
//					Children = {
//						new Label { Text = "Yellow" },
//						new BoxView { Color = Color.Yellow,
//							VerticalOptions = LayoutOptions.FillAndExpand},
//						//new BoxView { Color = Color.Gray}
//					}
//				}
//			});
//
//			this.Children.Add (new ContentPage {
//				Title = "Green",
//
//				Content = new StackLayout {
//					Children = {
//						new Label { Text = "Green" },
//						//new BoxView { Color = Color.Gray ,
//							//},
//						new BoxView { Color = Color.Green,
//						VerticalOptions = LayoutOptions.FillAndExpand}
//					}
//				}
//			});

		}
	}
}


