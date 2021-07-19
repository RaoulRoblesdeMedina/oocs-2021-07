using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramArrays
	{
		static void MainArrays(string[] args)
		{
			//var iets = 10; // lazy keyword
			//iets = "hoi";


			// multidimensional arrays

			int[,] grid = new int[3, 3];
			grid[0, 1] = 5677;
			grid[0, 2] = 98;

			// applying string theory
			//int[,,,,,,,,,,,,,,,,,,,,,,,,,] heelveeldimensies = new int[1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1];

			int grootte = int.Parse(Console.ReadLine());

			// lijstje (array) van getallen
			int[] getallen = new int[grootte];

			getallen[0] = 2576; // zero-based array. 0 1 2 3
			getallen[3] = 383;

			// hoe krijgen we deze erin?
			getallen[4] = 38485;


			Console.WriteLine("Eerste item: " + getallen[0]);

			foreach (int getal in getallen)
			{
				Console.WriteLine("Getal: " + getal);
			}

		}
	}
}
