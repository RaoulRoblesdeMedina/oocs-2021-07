using System;

namespace LoopDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			int index = 15;
			do
			{ // als je wil dat deze altijd minimaal 1 keer uitgevoerd wordt
				Console.WriteLine("hoi " + index);
			}
			while (index < 10);

			// while gebruik je meer als de indexwijzigingen meer fluctueren
			while (index > 10) // zolang de conditie true, gaat hij hierin. niet minimaal 1 keer ofzo.
			{


				Console.WriteLine("while index " + index);
				index -= 2;
			}

			// for en while zijn identiek aan elkaar qua loopgedrag
			// bij een for definieer je echter alles op 1 regel
			for (int i = 0; i < 8; i++)
			{
				Console.WriteLine("i for: " + i);
			}

			// om door een collectie/array/lijstje heen te gaan
			var lijstje = new int[] { 4, 8, 15 };
			foreach (var item in lijstje)
			{
				Console.WriteLine("item: " + item);
			}
		}
	}
}
