### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Facade pattern
The Facade Pattern provide a simplified interface to a complex system. 
Reduce the complexity in a one interface for the client.
OrderServiceFacade hides the complexity of order process.
With facade is more simple mantain the program, because you can you only one class, instead four class (authenticate, inventory, payment, fullfillment).