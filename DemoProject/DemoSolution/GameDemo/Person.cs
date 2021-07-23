using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
	public class Person
	{
		public string FirstName;

		public string LastName;

		public string Name
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
			set
			{
				// volledige vrijheid qua code


				if (value.Contains("rot"))
				{
					Console.WriteLine("rot mag niet voorkomen in de naam");
					return;
				}

				var firstSpace = value.IndexOf(" ");
				FirstName = value.Substring(0, firstSpace);
				LastName = value.Substring(firstSpace);

				// validaties
				Console.WriteLine("Name setter aangesproken met " + value + ", nu opgesplitst naar " + FirstName + " " + LastName);
			}
		}
	}
}
