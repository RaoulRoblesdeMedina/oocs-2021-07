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
			foreach(var c in oldPhone.Contacts)
			{
				var newContact = new Contact { Name = c.Name, PhoneNumber = c.PhoneNumber };
				newPhone.Contacts.Add(newContact);
			}
		}
	}
}
