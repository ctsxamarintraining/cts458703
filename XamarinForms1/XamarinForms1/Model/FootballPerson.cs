using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.ObjectModel;

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

		public void del(int i)
		{
			SQLiteConnection database;

			database = DependencyService.Get<ISQLite> ().GetConnection ();

			database.CreateTable<Person> ();
			database.Delete<Person> (i);



		}


		public string countryImage{

			get{ return String.Concat(country,".png");}
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
	

		public void updateplayerFavourite(Person obj)
		{
			SQLiteConnection database;

			database = DependencyService.Get<ISQLite> ().GetConnection ();

			database.CreateTable<Person> ();
			database.Update (obj);

		}
	}
}

