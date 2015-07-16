using System;

namespace nameProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("What's your name?");
			string theAge = Console.ReadLine();

			for(string i = 0; i < theAge.length; ++i)
			{
				Console.Write(theAge[i]);
			}

			Console.WriteLine();
		}
	}
}
