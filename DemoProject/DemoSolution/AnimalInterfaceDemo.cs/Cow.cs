using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaceDemo
{
	// een interface IMPLEMENTEER je
	// van een class kun je echt OVERERVEN/EXTENDEN

	public class Cow : IAnimal
	{
		public string Name { get; set; }

		public void Move()
		{
			Console.WriteLine("moving with cow legs");
		}
	}
}
