using System;

using Xamarin.Forms;

namespace XamarinForms1
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			RelativeLayout layout = new RelativeLayout {Padding=10};
			var label = new Label {
				Text = "Login Page",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),

			};

			layout.Children.Add (label,Constraint.Constant(120),Constraint.Constant(5));

			var username = new Entry {
				Placeholder = "Username"
			};
			layout.Children.Add(username,Constraint.Constant(120),Constraint.Constant(60));

			var password = new Entry { Placeholder = "Password", IsPassword = true };
			layout.Children.Add(password,Constraint.Constant(120),Constraint.Constant(160));

			var button = new Button { Text = "Sign In", TextColor = Color.Black };
			layout.Children.Add(button, Constraint.Constant(140),Constraint.Constant(235));

			button.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
				{
					DisplayAlert("Validation Error", "Username and Password are required", "Re-try");

					
				} else if(username.Text=="Nikhil" &&password.Text=="123456"){

				this.Navigation.PushAsync(new MasterPage());
					
				}
			};
				

			this.Content = layout;

		}
	}
}


