using System;
using System.Web;
using Newtonsoft.Json;

namespace JSONSerialization
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Product product = new Product();

			product.Name = "Apple";
			product.ExpiryDate = new DateTime(2008, 12, 28);
			product.Price = 3.99;
			product.Sizes = new string[] { "Small", "Medium", "Large" };
			product.color="Red";

			string output = JsonConvert.SerializeObject(product);
			Console.Write (output);
		}
	}
}
