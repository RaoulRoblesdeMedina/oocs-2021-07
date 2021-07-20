using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramOefeningStarOut // voor leesbaarheid: max 100-300 regels
	{
		static void Main(string[] args) // voor leesbaarheid: max 10-20 regels
		{

			string text = "sm*eilly";
			//string text = "ab**cd";

			for (int i = 0; i < text.Length; i++)
			{
				if (text.Substring(i, 1) == "*")
				{
					string ervoor = text.Substring(i - 1, 1);
					string erna = text.Substring(i + 1, 1);

					Console.WriteLine("* gevonden! eromheen: " + ervoor + " en " + erna);

					int endIndex = FindNextNonStarCharacter(text, i);

					Console.WriteLine("eind index: " + endIndex);

					int startIndex = i - 1;
					text = text.Remove(startIndex, (endIndex + 1) - startIndex);

					Console.WriteLine("iets verwijderd: " + text);
				}
				else
				{

				}
			}
		}

		// return value
		// returnwaarde
		// return parameter

		static int FindNextNonStarCharacter(string text, int startIndex)
		{
			// search for next non-star
			Console.WriteLine("op zoek naar een niet ster");
			for (int j = startIndex; j < text.Length; j++)
			{
				var c = text.Substring(j, 1);
				Console.WriteLine("is dit een *? " + c);

				if (c != "*")
				{
					Console.WriteLine("aha! geen ster. noteer die eindindex voor de remove iets verderop");
					return j;
				}
			}

			// hier komen we nu nog niet
			return -1;
		}
	}
}
