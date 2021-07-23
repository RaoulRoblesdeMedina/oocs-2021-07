using System;

namespace BankDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var ing = new Bank();

			var donald = new GoldRekening();
			donald.Rekeninghouder = "Donald Drumpf";
			donald.Saldo = 1_400_000;
			donald.Iban = "NL06RABO0385893239";
			
			var jeffy = new GoldRekening();
			jeffy.Rekeninghouder = "Jeffrey Bezos";
			jeffy.Iban = "US90349404305";
			jeffy.Saldo = 158_398_385_000;

			var janmodaal = new RegularRekening();
			janmodaal.Rekeninghouder = "Jan Modaal";
			janmodaal.Iban = "NL06RABO03934";
			janmodaal.Saldo = 115;

			ing.accounts[0] = donald;
			ing.accounts[1] = jeffy;
			ing.accounts[2] = janmodaal;

			var total = ing.TotalAmountOfMoney();
			Console.WriteLine("totaal: " + total);
			//Console.WriteLine("Jan heeft nu " + janmodaal.saldo + " euros");

			//ing.TransferMoney(jeffy, janmodaal, 10_000_000_000);

			//Console.WriteLine("Jeffy heeft nu " + jeffy.saldo + " euros");

			ing.PrintOverview();

			janmodaal.AddInterest(1.5M);

			ing.PrintOverview();

			Console.WriteLine("en nu voor iedereen");

			ing.AddInterest();

			ing.PrintOverview();

			donald.Buy(5000);

			janmodaal.Buy(26000);

			ing.PrintOverview();


		}
	}
}
