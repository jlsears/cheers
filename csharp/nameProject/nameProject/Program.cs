using System;

namespace nameProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("What's your name? ");
			string theName = Console.ReadLine();

			foreach (char c in theName) 
			{
				Console.WriteLine ("Can I have a " + c.ToString () + "?");
			}
				
			Console.WriteLine ("Goooooo " + theName + "!!!! :D");
		}
	}
}
