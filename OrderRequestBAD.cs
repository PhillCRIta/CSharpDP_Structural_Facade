using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Facade
{
	internal class OrderRequestBAD
	{
		public string Name { get; } = "Phill";
		public string CardNumber { get; } = "0123456789";
		public float Amount { get; } = 7.70f;
		public string Address { get; } = "Evergrin terrace";
		public string[] ItemsId { get; } = { "123", "abc", "def", "789" };
	}
}
