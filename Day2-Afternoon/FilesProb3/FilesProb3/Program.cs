using System;
using System.IO;

namespace FilesProb3
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			FileStream stream = File.OpenRead("Yourfile.txt");
			byte[] fileBytes= new byte[500];

			stream.Read(fileBytes, 0, 500);
			stream.Close();
			//Begins the process of writing the byte array back to a file

			using (Stream file = File.OpenWrite("Yourfile1.txt"))
			{
				file.Write(fileBytes, 0, fileBytes.Length);
			}


		}
	}
}
