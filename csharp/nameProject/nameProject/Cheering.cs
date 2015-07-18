using System;

namespace nameProject
{
	public static class Cheering //static because 
	{

		public static void Init () //voice because we're technically not returning anything
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

			var NorseList = "Halfnorsemix"; 

			//Cheering
			foreach (char c in theName) 
			{
				string whichOne; //use handy variable to determine whether to use "an" or "a" in statement

				if (NorseList.Contains(c.ToString())) { //applied ToString() to jimmy functionality in
					whichOne = "an ";
				} else {
					whichOne = "a ";
				}

				Console.WriteLine ("Can I have " + whichOne + c.ToString () + "?");
			}

			Console.WriteLine ("Goooooo " + theName + "!!!! :D");

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

