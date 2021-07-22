using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaceDemo
{
	public class Wurm : IAnimal
	{
		public string Name { get; }

		public void Move()
		{
			Console.WriteLine("squirming over the floor");
		}
	}
}
