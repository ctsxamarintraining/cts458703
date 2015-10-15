using System;
using System.Collections.Generic;
using System.Collections;

namespace IListDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{ //Console.Write ("gfdhsghy");

			Mylist test = new Mylist();

			// Populate the List
			Console.WriteLine("Populate the List");
			test.Add("a");
			test.Add("b");
			test.Add("c");
			test.Add("d");
			test.Add("e");
			test.Add("f");
			test.Add("g");
			test.Add("h");
			test.Printarray();
			Console.WriteLine();

			// Remove elements from the list
			Console.WriteLine("Remove elements from the list");
			test.Remove("g");
			test.Remove("h");
			test.Printarray();
			Console.WriteLine();

			// Add an element to the end of the list
			Console.WriteLine("Add an element to the end of the list");
			test.Add("l");
			test.Printarray();
			Console.WriteLine();

			// Insert an element into the middle of the list
			Console.WriteLine("Insert an element into the middle of the list");
			test.Insert(4, "z");
			test.Printarray();
			Console.WriteLine();

			// Check for specific elements in the list
			Console.WriteLine("Check for specific elements in the list");
			Console.WriteLine("List contains \"three\": {0}", test.Contains("a"));
			Console.WriteLine("List contains \"ten\": {0}", test.Contains("b"));

			//IList list = new IList (array);

		}
	}
}
