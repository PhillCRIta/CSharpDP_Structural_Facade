using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Facade
{
	internal class PaymentBAD
	{
		private readonly string _name;
		private readonly string _cardNumber;
		private readonly float _amount;

		public PaymentBAD(string name, string cardNumber, float amount)
		{
			_name = name;
			_cardNumber = cardNumber;
			_amount = amount;
		}

		public void Pay()
		{
			Console.WriteLine("I'm paying the order, charge the amount on card n#: " + _cardNumber);
		}
	}
}
