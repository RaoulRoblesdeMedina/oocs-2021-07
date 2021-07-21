using Ding = AnimalInheritanceDemo.Ding;
using Hoi = AnimalInheritanceDemo.Hoi;
using System;

namespace AnimalInheritanceDemo
{
	class Program : Object
	{
		static void Main(string[] args)
		{
			var animals = new Animal[3];
			animals[0] = new Bird();
			animals[1] = new Wurm();
			animals[2] = new Mouse();


			//Ding.Iets;
			//Hoi.Iets;


			//animals[2] = new Phone();

			foreach (var animal in animals)
			{
				animal.Move();
			}

			//var getallen = new int[3];
			//getallen[0] = "qqq";


		}
	}
}
