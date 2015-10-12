using System;
using System.Collections.Generic;
namespace LinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LinkedList<string> linked = new LinkedList<string>();
			//
			// Use AddLast method to add elements at the end.
			// Use AddFirst method to add element at the start.
			//
			linked.AddLast("Third");
			linked.AddLast("Fourth");
			linked.AddLast("Fifth");
			linked.AddFirst("Second");
			linked.AddLast("Sixth");
			linked.AddFirst("First");
			linked.RemoveFirst ();
			//linked.RemoveLast();
			linked.Find("Fourth");
			//linked.FindLast ("dog");
			int x=linked.Count;
			Console.WriteLine (x);


			// Insert a node before the second node (after the first node)
			//
			LinkedListNode<string> node = linked.Find("Third");
			linked.AddAfter(node, "inserted");
			//
			// Loop through the linked list.
			foreach (string s in linked)
				Console.WriteLine (s);
		}
	}
}
