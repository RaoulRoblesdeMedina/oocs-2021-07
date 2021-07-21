using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkInheritanceDemo
{
    public class VasteWerknemer : Werknemer
    {
		public decimal MaandLoon { get; set; }

		public VasteWerknemer()
		{
			Type = "Vaste werknemer";
		}

		public override decimal CalculateSalary()
		{
			return MaandLoon;
		}

		public override void PrintInfo()
		{
			Console.WriteLine($"{Name} is een vaste werknemer en krijgt vast {MaandLoon} euro per maand");
		}
	}
}
