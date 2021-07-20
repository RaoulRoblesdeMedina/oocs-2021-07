using System;

namespace DemoProject.OO
{
	class Program
	{
		static void Main(string[] args)
		{
			var jp = new Human(); // instantie
			jp.aantalOgen = 2;
			jp.haarkleur = "Blond";
			jp.Speak();

			var raoul = new Human();
			raoul.haarkleur = "Zwart";
			raoul.Speak();

			var robin = new Human();

		}
	}
}
