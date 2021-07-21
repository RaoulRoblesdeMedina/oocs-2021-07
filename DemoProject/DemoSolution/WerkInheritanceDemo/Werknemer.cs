using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkInheritanceDemo
{
    public class Werknemer
    {
		public string Name { get; set; }

		public virtual decimal CalculateSalary()
		{
			return 0M;
		}

		public virtual void PrintInfo()
		{

		}
	}
}
