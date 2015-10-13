using System;


namespace ExceptionHandling1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			try{
				Console.Write("Enter the number");
				string number = Console.ReadLine ();
				int m = Convert.ToInt32(number);

				double x = Math.Sqrt (m);
				Console.Write(x);
			}
			catch(ArgumentException){

				Console.Write ("Invalid  Number");
			}
			catch(FormatException){
				
				Console.Write ("Invalid  Number");

			}

			catch(NotFiniteNumberException) {
				Console.Write ("Invalid  Number");
			}

		}
	}
}
