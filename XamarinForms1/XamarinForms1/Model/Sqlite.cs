
using System;
using SQLite;

namespace XamarinForms1

{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
