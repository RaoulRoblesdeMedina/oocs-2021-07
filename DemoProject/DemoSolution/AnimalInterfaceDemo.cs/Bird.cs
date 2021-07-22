using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaceDemo
{
    public class Bird : IAnimal
    {
		public string Name { get; private set; }

		public void Move()
		{
			Console.WriteLine("flapping with wings");
		}
	}
}
