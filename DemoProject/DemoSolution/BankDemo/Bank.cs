using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	class Bank
	{
		public Bankrekening[] accounts = new Bankrekening[10];

		public long TotalAmountOfMoney()
		{
			long sum = 0;
			foreach (var account in accounts)
			{
				if (account != null) // als er een geheugenadres in zit
				{
					sum = sum + account.saldo;
				}
			}
			return sum;
		}

		public void TransferMoney(Bankrekening from, Bankrekening to, long amount)
		{
			from.Withdraw(amount);
			to.Deposit(amount);
		}

		public void AddInterest()
		{
			foreach (var account in accounts)
			{
				if (account != null) // als er een geheugenadres in zit
				{
					account.AddInterest(1.5M);
				}
			}
		}

		public void PrintOverview()
		{
			foreach (var account in accounts)
			{
				if (account != null) // als er een geheugenadres in zit
				{
					// string interpolation
					Console.WriteLine($"{account.rekeninghouder}\t{account.iban}\t{account.saldo}EUR");
				}
			}

			Console.WriteLine("================");
		}
	}
}
