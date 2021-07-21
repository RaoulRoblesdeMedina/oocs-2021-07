using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLab
{
    public class Phone
    {
		public string Merk { get; set; }

		public string Type { get; set; }

		public List<Contact> Contacts { get; set; } = new List<Contact>();
	}
}
