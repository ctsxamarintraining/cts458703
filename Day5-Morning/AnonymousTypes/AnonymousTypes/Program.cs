using System;

namespace AnonymousTypes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var persons = new[] { 
				new { id=1, Name= "Pranay" , City="Hyderabad"},
				new { id=2, Name= "Krunal", City="Banglore" },
				new { id=3, Name= "Hemang", City="Kerela" } 
			};

			foreach (var person in persons)
			{
				Console.WriteLine("PersonId :{0} PersonName:{1} City:{2} " ,person.id,person.Name,person.City);

			}
		}
	}
}
