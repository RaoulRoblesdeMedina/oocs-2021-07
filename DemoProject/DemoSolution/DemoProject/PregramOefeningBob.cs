using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramOefeningBob
	{
		static void MainBob(string[] args)
		{

			ContainsBob("beterschap bob"); // true
			ContainsBob("bob de bouwer"); // true
			ContainsBob("bobbierooboboe"); // true
			Console.WriteLine("=========");
			ContainsBob("hey daar");
			ContainsBob("bbllbb"); // false
			ContainsBob("ll cool b"); // false
			ContainsBob("niet best"); // false
			ContainsBob("bbmmmmbbl"); // false
		}

		static void ContainsBob(string text)
		{
			if (text.Length >= 3)
			{
				for (int i = 0; i < text.Length; i++) // perfect als index
				{
					if (text.Substring(i, 1) == "b")
					{
						// text lengte = 14
						// laatste "b" zit op index = 13
						// + 2  untilIndex = 15


						int untilIndex = i + 2;

						if (text.Length <= untilIndex)
						{
							Console.WriteLine("false 2");
							return;
						}

						if (text.Substring(i + 2, 1) == "b")
						{
							Console.WriteLine("true!");
							return;
						}
					}
				}

				Console.WriteLine("false");
			}
		}
	}
}
