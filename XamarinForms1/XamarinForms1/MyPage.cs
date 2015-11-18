using System;

using Xamarin.Forms;

namespace XamarinForms1
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			RelativeLayout stack = new RelativeLayout ();
			var myImage = new Image {Source = "Default.png",Opacity=0.5};



			var button = new Button { Text = "GoToForm",BackgroundColor=Color.Gray };
			stack.HorizontalOptions = LayoutOptions.Center;
			stack.VerticalOptions = LayoutOptions.Center;

			stack.Children.Add (myImage,Constraint.Constant(0),Constraint.Constant(0));
			stack.Children.Add (button,Constraint.Constant(130),Constraint.Constant(200));


			button.Clicked += (sender, e) => {
				this.Navigation.PushAsync (new FormPage ());
			};

			this.Content = stack;




		}
	}
}


