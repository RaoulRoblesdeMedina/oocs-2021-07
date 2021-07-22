using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Vehicle
    {

        // deze wordt opgehoogd door new Car() maar ook door new Bicycle()
		public static int AantalGeproduceerdeVehicles { get; set; } // 0

    }
}
