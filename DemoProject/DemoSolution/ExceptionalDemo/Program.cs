using System;
using System.IO;

namespace ExceptionalDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//int.Parse("dskjfhdjsklf");

			// C C++    C#

			// exceptions: errors

			DoeIets();

			//try
			//{
			//	DoeIets();
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine("Oei daar ging iets stuk");
			//}

			Console.WriteLine("Halllooo!");
		}


		static void DoeIets()
		{
			// nullreferenceexception
			string text = null;

			//GoldRekening rekening = null;
			//rekening.Iban

			Console.WriteLine(text.Length);



			// NullReferenceException
			// ArgumentException
			// ArgumentNullException
			// FormatException
			// DirectoryNotFoundException
			// FileNotFoundException
			// FileException
			// SqlException



			//File.WriteAllText("C:\\Tempertfuyikookiuyt\\bladiebla.txt", "hoi");

			//throw new FileNotFoundException();


		}
	}

	class MijnException : Exception
	{

	}
}
