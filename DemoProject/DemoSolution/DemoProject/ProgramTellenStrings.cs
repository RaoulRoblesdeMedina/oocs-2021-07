using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramTellenStrings
	{
		static void MainTellen(string[] args)
		{

			TelX1("x.x.x..xx.x.x", 'x'); // 7
			TelX1("x.x.xxxxxxxxx..xx.x.x", 'x'); // 15
			TelX1("+.+.pp..pp..", 'p'); // 4
			TelX1("+.+.qq..pp..", 'q'); // q: 2
			TelX1("+.+...pp..", '+'); // plusjes: 2
			TelX1("+.+.....", '.'); // puntjes: 6

			Doe();

			//var getallen1 = new int[] { 4, 8, 9, 2, 9, 1 };
			//var getallen2 = new int[] { 99, 9, 2, 9, 1 };

			//Tel9(getallen1); // 2
			//Tel9(getallen2); // 2

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


		static void Doe()
		{
			int index = 110;
			
			//"hoi".Trim()

			do
			{
				Console.WriteLine("Hoi! " + index);
				index = index + 20;
			}
			while (index < 100);
		}

		static void TelX1(string stringVar, char searchValue)
		{
			int count = 0;
			int x = 14;
			string bla = "";
			char izard = 'q';
			foreach (var s in stringVar)
			{
				if (s == searchValue)
				{
					count = count + 1;
				}
			}
			Console.WriteLine("Count: " + count);
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
