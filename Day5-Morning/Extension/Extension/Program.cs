using System;
using System.Collections.Generic;



namespace Extension
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str="hiiii i am mad mad guy";
			int countOfWords = str.GetNoOfWords ();

		
			Console.WriteLine ("No Of words :{0}", countOfWords);
			int countOfCharacters = str.GetNoOfCharacters ();
			Console.WriteLine ("No Of characters :{0}", countOfCharacters);


			string str1="hiiii i ";
			int count1= str1.GetNoOfWords ();
			Console.WriteLine ("No Of words :{0}", count1);

		}
	}
}
