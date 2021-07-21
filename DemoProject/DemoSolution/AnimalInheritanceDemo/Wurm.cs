using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceDemo
{
    public class Wurm : Animal
    {
		public override void Move()
		{
			Console.WriteLine("Verplaats lichaamsgewicht/kruipen");
		}
	}
}
