using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
	public class Store
	{
		// nu heeft elke store dezelfde producten???
		public List<Product> Products { get; set; } = new List<Product>
		{
			new Product { Description = "Koffiekopje", Price = 1.40M },
			new Product { Description = "Balpen", Price = 0.80M },
			new Product { Description = "Bril", Price = 230.99M },
			new Product { Description = "Appel", Price = 0.70M },
			new Product { Description = "Klok", Price = 45.50M },
			new Product { Description = "Smartphone", Price = 700M },
			new Product { Description = "Laptop", Price = 1399.99M }
		};


		public void FilterProducts(Predicate<Product> filter)
		{
			foreach (var product in Products)
			{
				if (filter(product))
				{
					Console.WriteLine($"Pred product: {product.Description} kost {product.Price}");
				}
			}
		}


		public void FilterExpensiveProducts()
		{
			foreach (var product in Products)
			{
				if (product.Price > 200M)
				{
					Console.WriteLine($"Dit product is duur: {product.Description} kost {product.Price}");
				}
			}
		}

		public void FilterProductsStartingWithB()
		{
			foreach (var product in Products)
			{
				if (product.Description.StartsWith("B"))
				{
					Console.WriteLine($"Dit product begint met een B: {product.Description} kost {product.Price}");
				}
			}
		}

		public void FilterCheapProducts()
		{
			foreach (var product in Products)
			{
				if (product.Price < 5)
				{
					Console.WriteLine($"Dit product is goedkoop: {product.Description} kost {product.Price}");
				}
			}
		}
	}
}
