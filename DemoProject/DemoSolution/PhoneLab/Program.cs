using System;

namespace PhoneLab
{
	class Program
	{
		static void Main(string[] args)
		{

			var oneplus6t = new Phone { Merk = "OnePlus", Type = "6t" };
			var oneplus9 = new Phone { Merk = "OnePlus", Type = "9" };

			oneplus6t.Contacts.Add(new Contact { Name = "Raoul", PhoneNumber = "06838489658" });
			oneplus6t.Contacts.Add(new Contact { Name = "Donald Trump", PhoneNumber = "+1 49584395995" });
			oneplus6t.Contacts.Add(new Contact { Name = "Alexander Graham Bell", PhoneNumber = "+1 1" });

			var bcc = new TechSupport();
			bcc.CopyContacts(oneplus6t, oneplus9);

			foreach (var c in oneplus9.Contacts)
			{
				Console.WriteLine($"Overgezet: {c.Name} is bereikbaar op {c.PhoneNumber}");
			}

			Console.WriteLine("Klaar");
		}
	}
}
