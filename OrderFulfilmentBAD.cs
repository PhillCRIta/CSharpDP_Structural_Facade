using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Facade
{
	internal class OrderFulfilmentBAD
	{
		private InventoryBAD _inventory;

		public OrderFulfilmentBAD(InventoryBAD inventory)
		{
			_inventory = inventory;
		}
		public void Fulfill(string name, string address, string[] items)
		{
			Console.WriteLine("Inserting order into db");
			foreach (var item in items)
			{
				_inventory.ReduceInventory(item, 1);
			}
		}
	}
}
