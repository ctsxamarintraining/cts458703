using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace XamarinForms1
{
	public partial class FootballPlayerPage : ContentPage
	{


		public FootballPlayerPage ()
		{
			
			InitializeComponent ();
		
			this.BindingContext = new FootballPlayerListViewModel();

		}


		void OnClick(object sender, EventArgs e)
		{

			this.Navigation.PushAsync (new FormPage ());
		}
	
//		public void OnDelete (object sender, EventArgs e)
//		{
//			//Person p = new Person ();
//
//			var x1 = (MenuItem)sender;
//			var x2 = x1.BindingContext;
//			Person x3 = (Person)x2;
//			x3.del (x3.key);
//
//			MessagingCenter.Send (this, "delete");
//			this.Navigation.PushAsync (new FootballPlayerPage ());
//
//
//
//		}

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{

			if (e.SelectedItem == null) {
				return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
			}


			this.Navigation.PushAsync (new FootballPlayerDetailsPage (e.SelectedItem));


		}
//		void AddAsFavourite(object sender, EventArgs e)
//		{
//			MenuItem button = (MenuItem)sender;
//
//			var x1 = (MenuItem)sender;
//			var x2 = x1.BindingContext;
//			Person x3 = (Person)x2;
//			x3.fav =	!x3.fav;
//			if (x3.fav) {
//
//
//				button.Text = "Un Favourite";
//			} else {
//				button.Text = "Mark Favourite";
//			}
//			x3.updateplayerFavourite (x3);
//			//this.DisplayAlert ("gaerg","fweft","cancel");
//		}


	



	}
}

