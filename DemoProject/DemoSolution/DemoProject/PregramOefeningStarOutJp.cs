using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramOefeningStarOutJp
	{
		static void Main(string[] args)
		{
			string text = "sm*eilly";
			//string text = "ab**cd";

			string result = "";
			int index = 0;
			while (index < text.Length)
			{
				if (text.Length > index + 1 &&
					text.Substring(index + 1, 1) == "*")
				{
					int endIndex = FindNextNonStarCharacter(text, index + 1);
					index = endIndex + 1;
				}
				else
				{
					result += text.Substring(index, 1);
					Console.WriteLine("result is nu: " + result);
					index++;
				}
			}

			Console.WriteLine("resultaat: " + result);
		}

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
