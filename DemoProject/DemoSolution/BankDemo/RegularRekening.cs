using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	public class RegularRekening : Bankrekening
	{
		public override void Buy(long price)
		{
			Console.WriteLine("Zonder rood staan iets betalen");
			if (saldo - price > 0)
			{
				saldo -= price;
			}
			else
			{
				Console.WriteLine("whooaaa dat is niet genoeg saldo");
			}
		}
	}
}
