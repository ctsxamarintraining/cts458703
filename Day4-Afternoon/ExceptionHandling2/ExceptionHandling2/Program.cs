using System;
using System.IO;

namespace ExceptionHandling2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try{
				Console.WriteLine("Enter the file name");
				string filename=Console.ReadLine();

				Console.WriteLine ("The full file path is {0}", Path.GetFullPath (filename));
				string WholeFileString=System.IO.File.ReadAllText(filename);
			    Console.Write (WholeFileString);
				}

			catch(FileNotFoundException){

				Console.WriteLine ("File does not exists, try filename:- Demo.txt");
			}
		}
	}
}
