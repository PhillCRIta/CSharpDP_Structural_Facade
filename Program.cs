using Structural_Facade;
/*
 * The Facade Pattern provide a simplified interface to a complex system. 
 * Reduce the complexity in a one interface for the client.
 * OrderServiceFacade hides the complexity of order process.
 * With facade is more simple mantain the program, because you can you only one class, instead four class (authenticate, inventory, payment, fullfillment)
 */

OrderRequestBAD orderRequest = new OrderRequestBAD();
AuthenticateBAD auth = new AuthenticateBAD();
InventoryBAD inventory = new InventoryBAD();
foreach(string id in orderRequest.ItemsId)
{
	inventory.CheckInventory(id);
}
PaymentBAD payment = new PaymentBAD(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
payment.Pay();
OrderFulfilmentBAD orderFullfillment = new OrderFulfilmentBAD(inventory);
orderFullfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemsId);

Console.WriteLine("************ Using facade");

OrderServiceFacade orderService = new OrderServiceFacade();
orderService.Order(orderRequest);