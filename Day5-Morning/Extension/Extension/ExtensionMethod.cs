using System;



namespace Extension
{
	public static class ExtensionMethod
	{
		public static int GetNoOfWords (this string input)
		{
			int c = 1;
			for (int i = 1; i < input.Length; i++) {
				if (char.IsWhiteSpace (input [i - 1]) == true) {
					if (char.IsLetterOrDigit (input [i]) == true ||
					    char.IsPunctuation (input [i])) {
						c++;
					}
				}
			}
			return c;
		}

		public  static int GetNoOfCharacters (this string input)
		{
			int c = 1;
			for (int i = 1; i < input.Length; i++) {
				if (char.IsWhiteSpace(input[i])) {
					
				} else {
					c++;
				}
			}
			return c;
		}
			

	}


}

