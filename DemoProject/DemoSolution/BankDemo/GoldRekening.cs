using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	public class GoldRekening : IBankrekening
	{
		public string Iban { get; set; }

		public long Saldo { get; set; }

		public string Rekeninghouder { get; set; }

		public decimal Discount { get; set; } = 15M;

		public void Deposit(long amount)
		{
			Saldo += amount;
		}

		public void Withdraw(long amount)
		{
			Saldo -= amount;
		}

		public void AddInterest(decimal interest)
		{
			var rente = (1 + (interest / 100));
			Saldo = Convert.ToInt64(Saldo * rente);
		}

		public void Buy(long price)
		{
			Console.WriteLine("Buying with disccooouunnt");
			var discountAmount = price / 100M * Discount;
			var discountPrice = price - discountAmount;
			Saldo -= Convert.ToInt64(discountPrice);
		}
	}
}
