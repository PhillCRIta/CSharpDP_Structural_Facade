using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Facade
{
	internal class OrderServiceFacade
	{
		//FACADE have a DEPENDENCY (use) with the following class
		public void Order(OrderRequestBAD orderRequest)
		{
			//OrderRequestBAD orderRequest = new OrderRequestBAD();
			AuthenticateBAD auth = new AuthenticateBAD();
			InventoryBAD inventory = new InventoryBAD();
			foreach (string id in orderRequest.ItemsId)
			{
				inventory.CheckInventory(id);
			}
			PaymentBAD payment = new PaymentBAD(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
			payment.Pay();
			OrderFulfilmentBAD orderFullfillment = new OrderFulfilmentBAD(inventory);
			orderFullfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemsId);
		}
	}
}
