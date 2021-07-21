using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.OO
{
	class CalculatorMetState
	{
		public int result;

		public void Add(int x)
		{
			result = result + x;
		}

		public void Multiply(int x)
		{
			result = result * x;
		}

		public void Divide(int x)
		{
			result = result / x;
		}

		public void Subtract(int x)
		{
			result = result - x;
		}
	}
}
