using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramControlStructures
	{
		static void MainControlStructures(string[] args) // opstartpunt van je applicatie
		{
			Console.WriteLine("hoi");

			// control structures

			LaatForZien();
			DemonstreerIf();
			Console.WriteLine("klaar");




		}

		static void LaatForZien()
		{
			for (int i = 5; i < 15; i++)
			{
				Console.WriteLine("i is nu: " + i);
			}
		}

		static void DemonstreerIf()
		{
			int getal = 18;
			//decimal.Parse("qwertgh");

			if (getal > 15)
			{
				Console.WriteLine("ja hij is groter");

				if (getal < 20)
				{
					Console.WriteLine("maar hij is wel kleiner dan 20");
					DoeIetsZinloos();
				}
				else
				{
					Console.WriteLine("en hij is zelfs niet kleiner dan 20");
				}

			}
			else
			{
				Console.WriteLine("nee hij is kleiner");
			}



			// later

			//if(wasSuccess)
			//{

			//}

		}

		static void DoeIetsZinloos()
		{
			Console.WriteLine("Hallo zinloos");
		}
	}
}
