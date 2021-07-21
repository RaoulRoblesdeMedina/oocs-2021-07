using System;

namespace BankDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var ing = new Bank();

			var donald = new Bankrekening();
			donald.rekeninghouder = "Donald Drumpf";
			donald.saldo = 1_400_000;
			donald.iban = "US94839095965";
			
			var jeffy = new Bankrekening();
			jeffy.rekeninghouder = "Jeffrey Bezos";
			jeffy.iban = "US90349404305";
			jeffy.saldo = 158_398_385_000;

			var janmodaal = new Bankrekening();
			janmodaal.rekeninghouder = "Jan Modaal";
			janmodaal.iban = "NL06RABO03934";
			janmodaal.saldo = 115;

			ing.accounts[0] = donald;
			ing.accounts[1] = jeffy;
			ing.accounts[2] = janmodaal;

			var total = ing.TotalAmountOfMoney();
			//Console.WriteLine("Jan heeft nu " + janmodaal.saldo + " euros");

			//ing.TransferMoney(jeffy, janmodaal, 10_000_000_000);

			//Console.WriteLine("Jeffy heeft nu " + jeffy.saldo + " euros");

			ing.PrintOverview();

			janmodaal.AddInterest(1.5M);

			ing.PrintOverview();

			Console.WriteLine("en nu voor iedereen");

			ing.AddInterest();

			ing.PrintOverview();
		}
	}
}
