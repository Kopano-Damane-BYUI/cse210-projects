using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Address objects
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create Customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Product objects
        Product product1 = new Product("Laptop", 101, 800.00, 2);
        Product product2 = new Product("Mouse", 102, 20.00, 1);
        Product product3 = new Product("Keyboard", 103, 50.00, 1);

        // Create Order objects
        List<Product> productsOrder1 = new List<Product> { product1, product2 };
        List<Product> productsOrder2 = new List<Product> { product2, product3 };

        Order order1 = new Order(customer1, productsOrder1);
        Order order2 = new Order(customer2, productsOrder2);

        // Display packing labels, shipping labels, and total costs
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Order 1 Cost: $" + order1.GetTotalCost());

        Console.WriteLine("\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Order 2 Cost: $" + order2.GetTotalCost());
    }
}