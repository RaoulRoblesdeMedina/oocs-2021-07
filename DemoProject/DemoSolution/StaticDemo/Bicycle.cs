using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Bicycle : Vehicle
    {
		public Bicycle()
		{
			Vehicle.AantalGeproduceerdeVehicles++;
		}
    }
}
