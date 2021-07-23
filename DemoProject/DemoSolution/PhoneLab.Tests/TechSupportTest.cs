using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLab.Apps;

namespace PhoneLab.Tests
{
	[TestClass]
	public class TechSupportTest
	{
		// mocking

		[TestMethod]
		public void CopyContactsWithThreeContacts()
		{
			// Arrange (setup)
			var bcc = new TechSupport();

			var oldPhone = new Phone();
			var oldAddressBook = new AddressBook();

			// inhoudelijke tekstjes maken op dit moment niet uit
			oldAddressBook.Contacts.Add(new Contact { Name = "q", PhoneNumber = "4" });
			oldAddressBook.Contacts.Add(new Contact { Name = "w", PhoneNumber = "7" });
			oldAddressBook.Contacts.Add(new Contact { Name = "e", PhoneNumber = "92" });

			oldPhone.Apps.Add(oldAddressBook);

			var newPhone = new Phone();
			var newAddressBook = new AddressBook();
			newPhone.Apps.Add(newAddressBook);

			// Act (doe)
			bcc.CopyContacts(oldPhone, newPhone);

			// Assert (verwachtingen toetsen)
			Assert.AreEqual(3, newAddressBook.Contacts.Count);
		}

		// deze werkt niet
		[TestMethod]
		public void CopyContactsWithNoContacts()
		{
			// Arrange (setup)
			var bcc = new TechSupport();

			var oldPhone = new Phone();
			var oldAddressBook = new AddressBook();

			oldPhone.Apps.Add(oldAddressBook);

			var newPhone = new Phone();
			var newAddressBook = new AddressBook();
			newPhone.Apps.Add(newAddressBook);

			// Act (doe)
			bcc.CopyContacts(oldPhone, newPhone);

			// Assert (verwachtingen toetsen)
			Assert.AreEqual(3, newAddressBook.Contacts.Count);
		}

		// deze werkt niet
		[TestMethod]
		public void CopyContactsWithoutAnAddressBook()
		{
			// Arrange (setup)
			var bcc = new TechSupport();

			var oldPhone = new Phone();

			var newPhone = new Phone();
			var newAddressBook = new AddressBook();
			newPhone.Apps.Add(newAddressBook);

			// Act (doe)
			bcc.CopyContacts(oldPhone, newPhone);

			// Assert (verwachtingen toetsen)
			Assert.AreEqual(3, newAddressBook.Contacts.Count);
		}
	}
}
