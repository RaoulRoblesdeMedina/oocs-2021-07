using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankDemo.Tests
{
	[TestClass]
	public class GoldRekeningTest
	{
		[TestMethod] // attribuut
		public void IbanSetWithTooLongANumberShouldNotDoAnything()
		{
			var rekening = new GoldRekening();
			rekening.Iban = "NL06RABO03858932395757457";

			// verwachting definieren
			Assert.IsNull(rekening.Iban);
		}

		[TestMethod] // attribuut
		public void IbanSetWithNoCountryCodeShouldNotDoAnything()
		{
			var rekening = new GoldRekening();
			rekening.Iban = "06RABO0385989339";

			// verwachting definieren
			Assert.IsNull(rekening.Iban);
		}

		[TestMethod] // attribuut
		public void IbanSetWithValidIbanShouldStoreIt()
		{
			var rekening = new GoldRekening();
			rekening.Iban = "NL06RABO0385989339";

			// verwachting definieren
			Assert.AreEqual("NL06RABO0385989339", rekening.Iban);
		}
	}
}
