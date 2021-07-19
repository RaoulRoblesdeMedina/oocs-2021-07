using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramOefeningMidden
	{
		static void Main(string[] args)
		{
			//IsInMidden("aaabaaa", "b"); // true
			IsInMidden("aaabaa", "b"); // false
			//IsInMidden("aabaa", "b"); // true
			//IsInMidden("aba", "b"); // true
			//IsInMidden("abbba", "bbb"); // true
			//IsInMidden("aabbbaa", "bbb"); // true
			//IsInMidden("aaaaaaaaaaaaaaaaaaaabbbaa", "bbb"); // false
			//IsInMidden("aabbaa", "bb"); // true
		}

		static void IsInMidden(string fullString, string middle)
		{


			var fullLength = fullString.Length;
			var middleLength = middle.Length;

			var halfFull = fullLength / 2;
			var halfMiddle = middleLength / 2;

			var startIndex = halfFull - halfMiddle;
			var hapje = fullString.Substring(startIndex, middleLength);

			if(hapje == middle)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}
}
