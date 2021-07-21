using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.OO
{
	internal class Car
	{
		// uniforme notiatie
		// mogelijkheid tot later toevoegen van validatie
		// => principe van encapsulatie
		public string Kenteken { get; set; } // property

		private string kleur; // field
		public string Kleur // property
		{
			get
			{
				Console.WriteLine("getter op kleur");
				return kleur;
			}
			set
			{
				Console.WriteLine("setter op kleur: " + value);
				if (value == null ||
					value.Contains("*"))
				{
					return;
				}
				kleur = value;
			}
		}

		public short Bouwjaar { get; set; }

		public byte SchadevrijeJaren { get; set; }

		public Human Berijder { get; set; }


		// defensief programmeren?


		// constructor: geen returntype
		public Car(string kenteken, string kleur, short bouwjaar)
		{
			Kenteken = kenteken;
			Kleur = kleur;
			Bouwjaar = bouwjaar;
		}

		// getters en setters: C# 2.0 get; set;
		//public string GetKleur()
		//{
		//	return kleur;
		//}
		//public void SetKleur(string nieuweKleur)
		//{
		//	if (nieuweKleur == null || 
		//		nieuweKleur.Contains("*"))
		//	{
		//		return;
		//	}

		//	this.kleur = nieuweKleur;
		//}

	}
}
