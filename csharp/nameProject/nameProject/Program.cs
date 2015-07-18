using System;

namespace nameProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Asking for name
			Console.Write ("What's your name? ");
			string theName = Console.ReadLine();

			//Printing name
			Console.WriteLine (theName);

			//Asking for birthday
			Console.Write ("What's your birthday? ");
			string theBirthday = Console.ReadLine ();

			//Birthday date info
			DateTime bdayConv = DateTime.Parse(theBirthday, System.Globalization.CultureInfo.InvariantCulture);
			int bdayMonth = bdayConv.Month;
			int bdayDate = bdayConv.Day;

			//Current date info
			DateTime rightNow = DateTime.Now;
			int todayMonth = rightNow.Month;
			int todayDate = rightNow.Day;

			//Printing birthday month and day
			Console.WriteLine (bdayMonth + "/" + bdayDate);

			//Finding the difference in days between dates
			var findingDiff = Math.Round((bdayConv - rightNow).TotalDays);

			//Cheering
			foreach (char c in theName) 
			{
				Console.WriteLine ("Can I have a " + c.ToString () + "?");
			}
				
			Console.WriteLine ("Goooooo awesome " + theName + "!!!! :D");

			//Determining the appropriate next response
			if ((bdayMonth == todayMonth) && (bdayDate == todayDate))
			{
				Console.WriteLine ("Happy birthday to you!!!");
			}

			else if (bdayConv > rightNow)
			{
				Console.WriteLine ("Your birthday is " + findingDiff + " days away!");
			}

			else
			{
				Console.WriteLine ("Your birthday is " + (365 - Math.Abs(findingDiff)) + " days away!");
			}
				
		}
	}
}
