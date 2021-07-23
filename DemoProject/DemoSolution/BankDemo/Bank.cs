

// je uset hier namespaces

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

		// verantwoordelijk voelen voor de data in deze class
		//public void AddAccount(IBankrekening newBankAccount)
		//{
		//	// kredietcheck

		//	accounts[3] = newBankAccount;
		//}



		public long TotalAmountOfMoney()
		{

			// chaining
			//accounts.Where(x => x != null).Where(x => x.Saldo > 5).Skip(2).Take(3);

			return accounts.Where(x => x != null).Sum(x => x.Saldo);


			//long sum = 0;
			//foreach (var account in accounts)
			//{
			//	if (account != null) // als er een geheugenadres in zit
			//	{
			//		sum = sum + account.Saldo;
			//	}
			//}
			//return sum;
		}

		public void TransferMoney(IBankrekening from, IBankrekening to, long amount)
		{
			from.Withdraw(amount);
			to.Deposit(amount);
		}

		public void AddInterest()
		{

			// if-statement in foreach is nu vervangen door de .Where() op dezelfde regel

			foreach (var account in accounts.Where(x => x != null))
			{
				account.AddInterest(1.5M);
			}
		}

		public void PrintOverview()
		{

			// if-statement in foreach is nu vervangen door de .Where() op dezelfde regel

			foreach (var account in accounts.Where(x => x != null))
			{
				// string interpolation
				Console.WriteLine($"{account.Rekeninghouder}\t{account.Iban}\t{account.Saldo}EUR");
			}

			Console.WriteLine("================");
		}
	}
}
