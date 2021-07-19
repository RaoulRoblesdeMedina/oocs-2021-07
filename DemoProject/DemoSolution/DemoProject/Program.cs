using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class Program
	{
		static void Main(string[] args)
		{


			var getallen1 = new int[] { 4, 8, 9, 2, 9, 1 };
			var getallen2 = new int[] { 99, 9, 2, 9, 1 };

			Tel9(getallen1); // 2
			Tel9(getallen2); // 2

			//BijnaHonderdOfTweehonderd(93); // true
			//BijnaHonderdOfTweehonderd(104); // true
			//BijnaHonderdOfTweehonderd(84); // false
			//BijnaHonderdOfTweehonderd(205); // true
			//BijnaHonderdOfTweehonderd(-103); // false


			//SleepIn(true, true); // vakantie
			//SleepIn(false, true); // vakantie
			//SleepIn(false, false); // weekend
			//SleepIn(true, false); // niet uitslapen
		}

		static void Tel9(int[] getallen)
		{
			int count = 0;
			foreach (int getal in getallen)
			{
				if (getal == 9)
				{
					count = count + 1;
				}
			}
			Console.WriteLine("aantal negens: " + count);
		}

		static void BijnaHonderdOfTweehonderd(int getal)
		{
			int upper100Bound = 110;
			int lower100Bound = 90;

			int upper200Bound = 210;
			int lower200Bound = 190;

			if ((getal > lower100Bound &&
				getal < upper100Bound) ||
				(getal > lower200Bound &&
				getal < upper200Bound))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}
		}

		static void SleepIn(bool isWeekday, bool isVacation)
		{
			if (isVacation)
			{
				Console.WriteLine("Ja uitslapen, vakantie");
			}
			else if (!isWeekday)
			{
				Console.WriteLine("Ja uitslapen, want weekend");
			}
			else
			{
				Console.WriteLine("Niet uitslapen");
			}
		}
	}
}
