using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLab.Apps
{
	public class AddressBook : IApp
	{
		public string Name { get; set; } = "GoatAddressBook";

		public List<Contact> Contacts { get; set; } = new List<Contact>();
	}
}
