using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Car : Vehicle
    {
		public string Make { get; set; }

		public string Model { get; set; }

		// deze wordt opgehoogd door new Car()
		public static int AantalGeproduceerdeAutos { get; set; }

		public Car()
		{
			Vehicle.AantalGeproduceerdeVehicles++;
			AantalGeproduceerdeAutos++;
			Console.WriteLine($"Er zijn nu {Vehicle.AantalGeproduceerdeVehicles} auto's geproduceerd");
		}

		public static decimal ConvertKilometersPerHourToMilesPerHour(decimal kilometers)
		{
			// gebruik je geen this? dan kan iets static worden.
			return kilometers * 1.6M;
		}
	}
}
