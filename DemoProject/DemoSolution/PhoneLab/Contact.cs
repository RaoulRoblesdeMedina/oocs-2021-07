using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLab
{
    public class Contact
    {
		// dit:
		public string Name { get; set; }

		// wordt door de compiler vertaald naar dit:

		//private string name2;  // backing field
		//public string Name2
		//{
		//	get
		//	{
		//		return name2;
		//	}
		//	set
		//	{
		//		name2 = value;
		//	}
		//}

		public string PhoneNumber { get; set; }
	}
}
