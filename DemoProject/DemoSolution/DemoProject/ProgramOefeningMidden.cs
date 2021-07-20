using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
	class ProgramOefeningMidden
	{
		static void MainMidden(string[] args)
		{
			IsInMidden("aaabaaa", "b"); // true
			IsInMidden("aabaa", "b"); // true
			IsInMidden("aba", "b"); // true
			IsInMidden("abba", "bb"); // true
			IsInMidden("aaaabbaaaa", "bb"); // true
			IsInMidden("aaaabbbbaaaa", "bbbb"); // true
			IsInMidden("abbba", "bbb"); // true
			IsInMidden("aabbbaa", "bbb"); // true
			IsInMidden("aabbaa", "bb"); // true

			Console.WriteLine("=========");

			IsInMidden("aaaaaaaaaaaaaaaaaaaabbbaa", "bbb"); // false
			IsInMidden("aaabaa", "b"); // false
			IsInMidden("abba", "b"); // false
			IsInMidden("abba", "bbb"); // false
			IsInMidden("abbbba", "bbb"); // false
			IsInMidden("aaaaaaabbba", "bbb"); // false
		}

		static void IsInMidden(string fullString, string middle)
		{
			if (IsEven(fullString.Length) && IsOdd(middle.Length))
			{
				Console.WriteLine("False 1");
				return;
			}

			var fullLength = fullString.Length;
			var middleLength = middle.Length;

			var halfFull = fullLength / 2;
			var halfMiddle = middleLength / 2;

			var startIndex = halfFull - halfMiddle;
			var hapje = fullString.Substring(startIndex, middleLength);

			if (hapje == middle)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}

		static bool IsOdd(int n)
		{
			return n % 2 != 0;
		}

		static bool IsEven(int n)
		{
			return n % 2 == 0;
		}
	}
}
