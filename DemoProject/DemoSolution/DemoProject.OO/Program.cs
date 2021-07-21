using System;

namespace DemoProject.OO
{
	class Program
	{
		static void Main(string[] args)
		{
			// voordat OO er was (PHP)
			string[] kentekens = new string[] { "31-ZH-PR", "41-MSP-5", "B-838-LB" };
			string[] kleuren = new string[] { "blauw", "blauw", "groen" };
			short[] bouwjaren = new short[] { 2004, 1998, 2014 };

			for (int i = 0; i < bouwjaren.Length; i++)
			{
				Console.WriteLine($"Auto met kenteken {kentekens[i]} is {kleuren[i]} en komt uit {bouwjaren[i]}");
			}

			Console.WriteLine("============");

			// OO-manier
			Car[] cars = new Car[3];
			cars[0] = new Car("31-ZH-PR", "blauw", 2004);
			cars[1] = new Car("41-MSP-5", "blauw", 1998);
			cars[2] = new Car("B-838-LB", "groen", 2014); // alles wat verplicht is

			cars[1].Kleur = "paars";
			cars[1].Kleur = null;
			cars[1].Kleur = "(*&^%$$^&*()&^%";

			

			//new Car() { kenteken = "94-KM-09", kleur = "rood", bouwjaar = 1999 };


			foreach (var car in cars)
			{
				Console.WriteLine($"Auto met kenteken {car.kenteken} is {car.Kleur} en komt uit {car.bouwjaar}");
			}

		}
	}
}
