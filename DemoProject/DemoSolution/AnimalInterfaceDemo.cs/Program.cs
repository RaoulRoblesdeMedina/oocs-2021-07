using System;

namespace AnimalInterfaceDemo.cs
{
	class Program
	{
		static void Main(string[] args)
		{
			//new IAnimal();

			var animals = new IAnimal[3];

			animals[0] = new Bird();
			animals[1] = new Wurm();
			animals[2] = new Cow();

			foreach (var animal in animals)
			{
				animal.Move();
			}


			// Polymorphisme
			Cow cow = new Cow();
			IAnimal cow2 = new Cow();
			Object cow3 = new Cow();

			IAnimal dier;

		}
	}
}
