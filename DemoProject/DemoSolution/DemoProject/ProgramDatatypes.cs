using System;

namespace DemoProject
{
	class ProgramDatatypes
	{
		static void MainDatatypes(string[] args) // max 10 lines
		{


			// datatype naam = waarde;

			int getal = 14;
			short getal1 = 4;
			byte getal2 = 9;
			bool waarofnietwaar = true;
			char letter = 'e';
			string tekst = "hallo";

			Console.WriteLine(tekst);

			decimal f = 10M / 3;


			// string concatenation
			Console.WriteLine("nog meer wauw! => " + f);


			// banken en andere financiele instellingen gebruiken geen double/float/decimal

			// ING slaat saldo's in gehele getallen op


			string input = Console.ReadLine();
			Console.WriteLine("ingegeven: " + input);


			double f1 = 0.1d;
			double f2 = 0.2d;

			try
			{ // code block

				double ingegevenGetal = double.Parse(input);
				double result = f1 + f2 + ingegevenGetal;
				Console.WriteLine("f1 + f2 + ingegevenGetal: " + result);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Hey maar dat is geen getal");
			}


			Console.WriteLine("Hier gaat hij verder");

			//int.Parse();
			//float.Parse();
			//short.Parse();
			//bool.Parse();

			//{
			//	int bla = 4;
			//	Console.WriteLine(bla);
			//}
		}
	}
}
