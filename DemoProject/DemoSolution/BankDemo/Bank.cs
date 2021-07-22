using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	class Bank
	{
		public IBankrekening[] accounts = new IBankrekening[10];

		public long TotalAmountOfMoney()
		{
			long sum = 0;
			foreach (var account in accounts)
			{
				if (account != null) // als er een geheugenadres in zit
				{
					sum = sum + account.Saldo;
				}
			}
			return sum;
		}

		public void TransferMoney(IBankrekening from, IBankrekening to, long amount)
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
					Console.WriteLine($"{account.Rekeninghouder}\t{account.Iban}\t{account.Saldo}EUR");
				}
			}

			Console.WriteLine("================");
		}
	}
}
