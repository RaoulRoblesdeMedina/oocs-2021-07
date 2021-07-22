using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	// een abstracte class vind ik hier handiger want Deposit()/Withdraw() zijn hetzelfde bij de 
	// subclasses

	// testbaarheid: unittests => interfaces komen hier ook veel terug
	public interface IBankrekening
	{
		public string Iban { get; }

		public long Saldo { get; }

		public string Rekeninghouder { get; }

		void Deposit(long amount);

		void Withdraw(long amount);

		void AddInterest(decimal interest);

		void Buy(long price);
	}
}
