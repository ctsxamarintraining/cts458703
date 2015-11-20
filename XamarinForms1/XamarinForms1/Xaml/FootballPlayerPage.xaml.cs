using System;
using System.Collections.Generic;
using SQLite;

using Xamarin.Forms;

namespace XamarinForms1
{
	public partial class FootballPlayerPage : ContentPage
	{
		public FootballPlayerPage (TableQuery<Person> personObjects)
		{
			this.BindingContext = new FootballPlayerListViewModel(personObjects);
			InitializeComponent ();


		
		}

		void OnClick(object sender, EventArgs e)
		{

			this.Navigation.PushAsync (new FormPage ());
			//ToolbarItem tbi = (ToolbarItem) sender;
			//this.DisplayAlert("Selected!", tbi.Name,"OK");
		}


	}
}

