using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace XamarinForms1
{
	public class Person
	{
		[PrimaryKey,AutoIncrement]
		public int key{ get; set;}

		public Person(){
	
		}
			public string cName{ get; set; }
		public string gender{ get; set; }
		public  string country{ get; set; }
		public string date{ get; set; }
		public string descriptiondet{ get; set; }
		public bool fav{ get; set ; }


		public ICommand DeleteCommand
		{


			get {
				return new Command<Person> (execute: (Person theplayer)=>
					{
						SQLiteConnection database;
						database = DependencyService.Get<ISQLite> ().GetConnection ();
						List<Person> newplayerlist = database.Query<Person> ("SELECT * FROM Person WHERE cName = ?", theplayer.cName);
						database.Delete (newplayerlist [0]);  
						MessagingCenter.Send(this,"SomethingHappened");
					});
			}
		}


		public ICommand FavouriteCommand
		{

			get {
				return new Command<Person> (execute: (Person theplayer)=>
					{
						SQLiteConnection database;
						database = DependencyService.Get<ISQLite> ().GetConnection ();
						List<Person> newplayerlist = database.Query<Person> ("SELECT * FROM Person WHERE cName = ?", theplayer.cName);
						newplayerlist [0].fav = !(newplayerlist [0].fav);

						database.Update (newplayerlist [0]);  
						MessagingCenter.Send(this,"SomethingHappened");
					
					});
			}
		}




		public string countryImage{

			get{ return String.Concat(country,".png");}
		}

		public string Favourite{
			
			get{
				 string str;
				if (fav) {
					str = "Favourite";
					return str;
				} else if (!fav) {

					str = "Unfavourite";
					return str;
				} 
				else {
					return "hbj";
				}

			}

	
		}


		public Person (bool f,string customerName, string customerGender, string description, string dateSelected, string countrySelected)
			{
				cName = customerName;
				gender = customerGender;
				date = dateSelected;
			country = countrySelected;
				descriptiondet = description;
			fav = f;
			}
	


	}
}

