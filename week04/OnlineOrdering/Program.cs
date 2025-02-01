using System;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("456 Sunset Blvd", "New York", "NY", "USA");
        Customer cust1 = new Customer("Racheal Katono", addr1);
        
        Product prod1 = new Product("4K Smart TV", "TV123", 899.99, 1);
        Product prod2 = new Product("Bluetooth Speaker", "BS456", 59.99, 2);
        Product prod3 = new Product("Mechanical Keyboard", "MK789", 129.99, 1);
        
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Address addr2 = new Address("78 Maple Lane", "London", "ON", "Canada");
        Customer cust2 = new Customer("Roike Mwine", addr2);
        
        Product prod4 = new Product("Smartwatch", "SW321", 199.99, 2);
        Product prod5 = new Product("Wireless Earbuds", "WE654", 79.99, 3);
        
        Order order2 = new Order(cust2);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
