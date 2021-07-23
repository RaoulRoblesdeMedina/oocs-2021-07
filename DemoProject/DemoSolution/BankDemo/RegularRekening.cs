using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	public class RegularRekening : IBankrekening
	{
		public string Iban { get; set; }

		public long Saldo { get; set; }

		public string Rekeninghouder { get; set; }

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
			// hier try-catch? hangt van de gebruiksvriendelijkheid van je project
			// - zit er een UI vast aan je applicatie? dan try-catch
			//   => misschien kun je globale errorhandler ergens registreren
			// - ben je een 1 of andere backenservice? dan exception.


			Console.WriteLine("Zonder rood staan iets betalen");
			if (Saldo - price > 0)
			{
				Saldo -= price;
			}
			else
			{
				throw new Exception("Harder werken voor je geld gozert");
			}
		}
	}
}
