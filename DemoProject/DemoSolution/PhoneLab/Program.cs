using PhoneLab.Apps;
using System;

namespace PhoneLab
{
	class Program
	{

		// in real life, waar de main voor wordt gebruikt:
		// opstarten. initializeren.

		static void Main(string[] args) // simuleer vanaf hier de gebruiker, eigenlijk alleen maar aanroepen
		{

			// create old phone with apps
			var oneplus6t = new Phone { Merk = "OnePlus", Type = "6t" }; // maak nieuwe telefoon
			var addressBook6t = new AddressBook(); // app adresboek aanmaken

			oneplus6t.Apps.Add(new Calculator()); // maak en koppel calculator aan telefoon
			oneplus6t.Apps.Add(addressBook6t); // koppel adresboek aan telefoon

			// contacten toevoegen
			// dit doe ik hier, want als ik dit in de class AddressBook opneem, dan heeft ieder adresboek
			// standaard allemaal dezelfde set aan contacten. Zie Tom van MySpace.
			// also: een class hoort gedrag te bevatten. De gebruiker voegt contacten toe, het systeem zou dit
			// niet moeten doen.
			addressBook6t.Contacts.Add(new Contact { Name = "Raoul", PhoneNumber = "06838489658" });
			addressBook6t.Contacts.Add(new Contact { Name = "Donald Trump", PhoneNumber = "+1 49584395995" });
			addressBook6t.Contacts.Add(new Contact { Name = "Alexander Graham Bell", PhoneNumber = "+1 1" });

			// create new phone with apps
			var oneplus9 = new Phone { Merk = "OnePlus", Type = "9" }; // maak nieuwe telefoon
			var addressBook9 = new AddressBook(); // app adresboek aanmaken

			oneplus9.Apps.Add(addressBook9); // koppel adresboek aan telefoon

			// let tech support help me with my contacts
			var bcc = new TechSupport();
			bcc.CopyContacts(oneplus6t, oneplus9); // deze functionaliteit uitvoeren zodat ik straks kan kijken of 
			// dat gelukt is

			foreach (var c in addressBook9.Contacts)
			{
				Console.WriteLine($"Overgezet: {c.Name} is bereikbaar op {c.PhoneNumber}");
			}

			Console.WriteLine("Klaar");



			

		}
	}
}
