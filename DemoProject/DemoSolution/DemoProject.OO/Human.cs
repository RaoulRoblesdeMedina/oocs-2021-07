using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.OO
{
	class Human
	{

		// visibility modifier

		public int aantalOgen;
		public string haarkleur;
		public Human partner;

		public void Speak()
		{
			int getal = 14;
			Console.WriteLine("Ik vind dat mijn " + haarkleur + "e haar heel mooi is");
		}

		public void Move()
		{

		}
	}
}
