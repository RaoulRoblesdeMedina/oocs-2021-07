using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankDemo
{
	public class GoldRekening : IBankrekening
	{
		private string iban;
		public string Iban
		{
			get
			{
				return iban;
			}
			set
			{
				// regular expressions

				// stap 1: algemene regels

				// stap 2: if()

				var regex = new Regex("^[A-Z]{2}[0-9]{2}[A-Z]{4}[0-9]{10}$");
				if(!regex.IsMatch(value))
				{
					Console.WriteLine("Geen geldige IBAN");
					return;
				}

				Console.WriteLine("prima geldig");
				iban = value;
			}
		}

		public long Saldo { get; set; } // sugary syntax
		// wordt door de compiler vertaald naar
		//private long saldo;
		//public long Saldo
		//{
		//	get
		//	{
		//		return saldo;
		//	}
		//	set
		//	{
		//		saldo = value;
		//	}
		//}
		 // sugary syntax

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
