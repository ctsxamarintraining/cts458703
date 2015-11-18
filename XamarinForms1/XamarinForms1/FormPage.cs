using System;

using Xamarin.Forms;

namespace XamarinForms1
{
	public class FormPage : ContentPage
	{
		public FormPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


