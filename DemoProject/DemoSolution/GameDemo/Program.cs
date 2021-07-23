using System;
using System.Collections.Generic;

namespace GameDemo
{
	class Program
	{
		static void Main(string[] args)
		{


			var games = new List<Game>();

			// iedere class, principieel gezien, voelt hij zich obsessief verantwoordelijk


			//new Game { Title = "Ori and the Blind Forest", ReleaseDate = new DateTime(2017, 4, 3) };
			//new Game { Title = ")(*&^%^&*(", ReleaseDate = new DateTime(1440, 4, 3) };

			var jp = new Person { FirstName = "JP", LastName = "ten Berge" };

			jp.Name = "rotFrank de Boer"; // set


			Console.WriteLine($"naam: {jp.Name}"); // get




		}
	}
}
