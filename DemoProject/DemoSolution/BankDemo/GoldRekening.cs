using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	public class GoldRekening : Bankrekening
	{
		public decimal Discount { get; set; } = 15M;

		public override void Buy(long price)
		{
			Console.WriteLine("Buying with disccooouunnt");
			var discountAmount = price / 100M * Discount;
			var discountPrice = price - discountAmount;
			saldo -= Convert.ToInt64(discountPrice);
		}
	}
}
