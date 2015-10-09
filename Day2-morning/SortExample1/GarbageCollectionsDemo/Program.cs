using System;

namespace GarbageCollectionsDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("hjbfiesa");
			long mem1 = GC.GetTotalMemory(false);
			{
				// Allocate an array and make it unreachable.
				int[] values = new int[50000];
				Console.WriteLine(mem1);
				values = null;
			}
			long mem2 = GC.GetTotalMemory(false);
			{
				// Collect garbage.
				GC.Collect();
			}
			long mem3 = GC.GetTotalMemory(false);
			{
				Console.WriteLine(mem1);
				Console.WriteLine(mem2);
				Console.WriteLine(mem3);
			}
		}
	}
}
