using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkInheritanceDemo
{
    public class Freelancer : Werknemer
    {
		public decimal Uurloon { get; set; }

		public int WerkurenPerWeek { get; set; }

		public override decimal CalculateSalary()
		{
			return Uurloon * WerkurenPerWeek * 4.5M;
		}

		public override void PrintInfo()
		{
			Console.WriteLine($"{Name} is een freelancer en krijgt {Uurloon} euro per uur, met {WerkurenPerWeek} uren per week komt dat uit op {CalculateSalary()} euro per maand");
		}
	}
}
