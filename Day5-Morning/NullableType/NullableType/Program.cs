using System;

namespace NullableType
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int? i = null;
			Console.WriteLine (i);
			i = 10;
			Console.WriteLine ("After Assigning the value becomes : {0}",i);

		}
	}
}
