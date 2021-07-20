using System;

namespace BankDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var ing = new Bank();

			var donald = new Bankrekening();
			donald.saldo = 1_400_000;
			
			var jeffy = new Bankrekening();
			jeffy.saldo = 158_398_385_000;

			var janmodaal = new Bankrekening();
			janmodaal.saldo = 12800;

			ing.accounts[0] = donald;
			ing.accounts[1] = jeffy;
			ing.accounts[2] = janmodaal;

			var total = ing.TotalAmountOfMoney();
			Console.WriteLine("Total amount is " + total + " euros");

			Console.WriteLine("Jeffy heeft nu " + jeffy.saldo + " euros");
			Console.WriteLine("Jan heeft nu " + janmodaal.saldo + " euros");

			ing.TransferMoney(jeffy, janmodaal, 10_000_000_000);

			Console.WriteLine("Jeffy heeft nu " + jeffy.saldo + " euros");
			Console.WriteLine("Jan heeft nu " + janmodaal.saldo + " euros");
		}
	}
}
