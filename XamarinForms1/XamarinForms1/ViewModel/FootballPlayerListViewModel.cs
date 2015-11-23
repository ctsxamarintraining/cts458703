using System;
using System.Collections.ObjectModel;
using SQLite;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinForms1
{
	public class FootballPlayerListViewModel
	{


		public string cName{ get; set; }
		public string gender{ get; set; }
		public string country{ get; set; }
		public string date{ get; set; }
		public string descriptiondet{ get; set; }
		public bool fav{ get; set ; }

		public FootballPlayerListViewModel ()
		{
			SQLiteConnection database;
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			var personObjects = database.Table<Person>();
			Football_Player = new ObservableCollection<Person> ();



			foreach (Person p in personObjects) {


				Debug.WriteLine (p.country);
				Football_Player.Add (p);
			}
		



		}


		public ObservableCollection<Person> Football_Player{ get; set;}
	}
}

