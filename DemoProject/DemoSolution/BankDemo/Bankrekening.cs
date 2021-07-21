﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
	class Bankrekening
	{
		public string iban;

		public long saldo;

		public string rekeninghouder;

		public void Deposit(long amount)
		{
			saldo = saldo + amount;
		}

		public void Withdraw(long amount)
		{
			saldo = saldo - amount;
		}

		public void AddInterest(decimal interest)
		{
			var rente = (1 + (interest / 100));
			saldo = Convert.ToInt64(saldo * rente);
		}
	}
}
