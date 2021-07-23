using PhoneLab.Apps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLab
{
	public class TechSupport
	{
		public void CopyContacts(Phone oldPhone, Phone newPhone)
		{
			var oldAddressBook = GetAddressBookForPhone(oldPhone);
			var newAddressBook = GetAddressBookForPhone(newPhone);

			foreach (var c in oldAddressBook.Contacts)
			{
				var newContact = new Contact { Name = c.Name, PhoneNumber = c.PhoneNumber };
				newAddressBook.Contacts.Add(newContact);
			}
		}

		public AddressBook GetAddressBookForPhone(Phone p)
		{
			// zolang ik het kan lezen, vind ik in principe prima.

			// abstractie: ik hoef niet 100% alle details te kennen zolang als het werkt.
			// gaat het stuk? dan ga ik wel de diepte in en kijken wat er gebeurt

			return p.Apps.OfType<AddressBook>().Single();
			// is hetzelfde als:
			//return (AddressBook)p.Apps.Single(app => app is AddressBook);

			// en dat is bijna hetzelfde als:

			//foreach (var app in p.Apps)
			//{
			//	if (app is AddressBook)
			//	{
			//		// ik als developer heb alle checks uitgevoerd, ik weet zeker dat het een AddressBook is
			//		// hieronder cast ik de app van een IApp naar een AddressBook type
			//		// compiler, suck it
			//		return (AddressBook)app;
			//	}
			//}

			//// als er geen adresboek in de applijst is
			///// throw new Exception();
			//return null;
		}
	}
}
