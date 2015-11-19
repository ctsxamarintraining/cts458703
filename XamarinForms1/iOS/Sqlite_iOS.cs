﻿using System;
using SQLite;
using System.IO;
using XamarinForms1.iOS;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency (typeof(Sqlite_iOS))]

namespace XamarinForms1.iOS
{
	public class Sqlite_iOS:ISQLite
	{
		public Sqlite_iOS ()
		{
		}

		public SQLite.SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "PersonSQLite.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			Console.WriteLine (documentsPath);
			var mypath = Path.Combine (documentsPath,sqliteFilename);


	
			var conn = new SQLite.SQLiteConnection(mypath);


			return conn;
		}
	}
}
		