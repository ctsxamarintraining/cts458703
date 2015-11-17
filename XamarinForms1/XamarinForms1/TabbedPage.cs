using System;

using Xamarin.Forms;

namespace XamarinForms1
{
	public class TabbedPage : Xamarin.Forms.TabbedPage
	{
		public TabbedPage ()
		{


			this.Title = "TabbedPage";
			this.Children.Add (new ContentPage {
				Title = "Gray",

				Content = new StackLayout {
					Children = {
						new Label { Text = " Gray" },
						new BoxView { Color = Color.Gray,
							VerticalOptions = LayoutOptions.FillAndExpand },
						//new BoxView { Color = Color.Green}
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "Blue ",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Blue" },
						new BoxView { Color = Color.Blue,
							VerticalOptions = LayoutOptions.FillAndExpand},
						//new BoxView { Color = Color.Red}
					}
				}
			});


			this.Children.Add (new ContentPage {
				Title = "Yellow",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Yellow" },
						new BoxView { Color = Color.Yellow,
							VerticalOptions = LayoutOptions.FillAndExpand},
						//new BoxView { Color = Color.Gray}
					}
				}
			});

			this.Children.Add (new ContentPage {
				Title = "Green",

				Content = new StackLayout {
					Children = {
						new Label { Text = "Green" },
						//new BoxView { Color = Color.Gray ,
							//},
						new BoxView { Color = Color.Green,
						VerticalOptions = LayoutOptions.FillAndExpand}
					}
				}
			});

		}
	}
}


