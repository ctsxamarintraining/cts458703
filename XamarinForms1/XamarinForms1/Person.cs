using System;

namespace XamarinForms1
{
	public class Person
	{
			public string cName{ get; set; }
		public string gender{ get; set; }
		public string country{ get; set; }
		public string date{ get; set; }
		public string descriptiondet{ get; set; }



			public Person (string customerName, string customerGender, string description, string dateSelected)
			{
				cName = customerName;
				gender = customerGender;
				date = dateSelected;
				descriptiondet = description;
			}
	}
}

