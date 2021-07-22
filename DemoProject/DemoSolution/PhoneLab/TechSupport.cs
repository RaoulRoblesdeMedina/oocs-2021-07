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
			foreach (var app in p.Apps)
			{
				if (app is AddressBook)
				{
					// ik als developer heb alle checks uitgevoerd, ik weet zeker dat het een AddressBook is
					// hieronder cast ik de app van een IApp naar een AddressBook type
					// compiler, suck it
					return (AddressBook)app;
				}
			}

			// als er geen adresboek in de applijst is
			return null;
		}
	}
}
