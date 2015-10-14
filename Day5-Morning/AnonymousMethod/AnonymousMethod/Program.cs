using System;

namespace AnonymousMethod
{
	class MainClass
	{
		public delegate void printString(string s);
		public delegate void printDetails(string name, int id, string city);


		public static void Main (string[] args)
		{

			printString input = delegate(string a) {

				Console.WriteLine ("Anonymous Method is {0}", a);
			};

			input ("implemented");


			printDetails details = delegate(string a, int b, string c) {

				Console.WriteLine ("Anonymous Method is used: NAme is {0}, Id is :{1}, and City is :{2}", a,b,c);
			};

			details ("Nishant", 458975, "Hyderabad");

		}


	}
}
