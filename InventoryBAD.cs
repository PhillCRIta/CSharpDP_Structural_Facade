using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Facade
{
	internal class InventoryBAD
	{
		public bool CheckInventory(string itemId)
		{
			return true;
		}
		public void ReduceInventory(string itemId, int amount)
		{
			Console.WriteLine("Reducing inventory " + itemId + " by " + amount);
		}
	}
}
