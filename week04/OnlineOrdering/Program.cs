using System;

class Program
{
    static void Main()
    {
        // Order 1 - USA Customer
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 900, 1));
        order1.AddProduct(new Product("Mouse", "P200", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        // Order 2 - International Customer
        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Chen", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P300", 300, 1));
        order2.AddProduct(new Product("Keyboard", "P400", 80, 1));
        order2.AddProduct(new Product("Case", "P500", 25, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
