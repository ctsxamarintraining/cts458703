using System;
using System.IO;
namespace FileReverse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FileStream fs1 = new FileStream("Yourfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer = new StreamWriter(fs1);
			writer.Write("Hello Welcome Sharath and Sajid");
			writer.Close();


			TextReader tr = new StreamReader("Yourfile.txt");

			// read a line of text
			//Console.WriteLine( tr.ReadLine());
		
			string WholeFileString=tr.ReadToEnd();
			char []strArray = WholeFileString.ToCharArray();
			Array.Reverse(strArray);
			//again convert to string
			string newStr = new string(strArray);
			Console.WriteLine (newStr);
			// close the stream
			tr.Close();


			FileStream fs2= new FileStream("Yourfile1.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer1 = new StreamWriter(fs2);
			writer1.Write(newStr);
			writer1.Close();



		}
	}
}
