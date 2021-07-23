using System;
using System.Linq;

namespace DelegateDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var mediamarkt = new Store();
			mediamarkt.FilterExpensiveProducts();
			Console.WriteLine("=============");
			mediamarkt.FilterProductsStartingWithB();
			Console.WriteLine("=============");
			mediamarkt.FilterCheapProducts();
			Console.WriteLine("--------------------");
			Console.WriteLine("--------------------");




			Predicate<Product> startingWithLetterPred = delegate (Product p)
			{
				return p.Description.StartsWith("B");
			};
			Predicate<Product> cheapPred = (Product p) => // lambda expression is gewoon een delegate
			{
				return p.Price < 5M;
			};

			// deze notatie hieronder is de verkorting variant van de predicates hierboven.
			// en is verder 100% hetzelfde. Dus hieronder is puur een syntaxverrijking voor betere
			// leesbaarheid, ironisch genoeg.
			mediamarkt.FilterProducts(p => p.Price > 200M); // functioneel programmeren

			Console.WriteLine("=============");
			mediamarkt.FilterProducts(startingWithLetterPred);
			Console.WriteLine("=============");
			mediamarkt.FilterProducts(cheapPred);

			foreach (var product in mediamarkt.Products.Where(p => p.Price > 40M))
			{
				Console.WriteLine("product: " + product.Description + " kost " + product.Price);
			}
		}
	}
}
