using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// hoe de wereld eruit zag voor generics

			ArrayList lijstje = new ArrayList();
			lijstje.Add(4); // toevoegen
			lijstje.Add(8);
			lijstje.Add(15);
			lijstje.Add(16);
			lijstje.Add(23);
			lijstje.Add(42);
			lijstje.Add("hoi");
			lijstje.Add(new object());
			lijstje.Add(new ArrayList());

			foreach (var getal in lijstje)
			{
				if (getal is int)
				{
					var echtGetal = (int)getal;
					Console.WriteLine("getal: " + (echtGetal * 2)); // * 4 "hoi" "hoihoihoihoi"
				}
				else if (getal is string)
				{
					Console.WriteLine("stringetje: " + getal);
				}
				else
				{
					Console.WriteLine("onmogelijke waarde gedetecteerd");
				}
			}



			// List<>  C# 2  generics

			var nogEenLijstje = new List<int> { 4, 8, 4844, 44, 43, 43, 4343 }; // initializeren van je lijst

			var teksten = new List<string> { "hoi", "doei", "bla" };



			var getallenlijstje = new List<int>(); // intern gebruikt deze een array
			getallenlijstje.Add(4); // toevoegen
			getallenlijstje.Add(8);
			getallenlijstje.Add(15);
			getallenlijstje.Add(16);
			getallenlijstje.Add(23);
			getallenlijstje.Add(42);
			//getallenlijstje.Add("hoi");
			//getallenlijstje.Add(new object());
			//getallenlijstje.Add(new ArrayList());

			foreach (var getal in getallenlijstje)
			{
				Console.WriteLine("getal: " + (getal * 2)); // * 4 "hoi" "hoihoihoihoi"
			}




			// andere soorten collecties / andere datastructuur
			// List<int>

			var gelinkteLijst = new LinkedList<int>();
			gelinkteLijst.AddLast(4);
			gelinkteLijst.AddLast(8);
			gelinkteLijst.AddLast(15);
			gelinkteLijst.AddLast(125);
			gelinkteLijst.AddLast(4);
			gelinkteLijst.AddLast(454);
			gelinkteLijst.AddLast(950);

			foreach (var item in gelinkteLijst)
			{

			}



			// hashmap - key-value pair
			var users = new Dictionary<string, User>();
			users.Add("jp@jp.nl", new User());
			users.Add("robin@robin.nl", new User());

			// verderop
			users.GetValueOrDefault("jp@jp.nl").GeefGeld();

			// simpel voorbeeldje

			var tekst = "hoi! ik ben jp en het is bijna weekend en yaaaayy";

			var count = new Dictionary<char, int>();
			foreach (var c in tekst)
			{
				if (!count.ContainsKey(c))
				{
					Console.WriteLine($"{c} staat nog niet in de dictionary");
					count.Add(c, 0);
				}

				count[c]++;
			}

			foreach (var item in count)
			{
				Console.WriteLine($"het karakter {item.Key} kwam {item.Value} keer voor");
			}
		}
	}
}
