using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor to initialize order with customer and product list
    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalProductCost = 0;

        // Add up the total cost of all products
        foreach (var product in products)
        {
            totalProductCost += product.GetTotalCost();
        }

        // Add shipping cost depending on the customer's location
        double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
        return totalProductCost + shippingCost;
    }

    // Method to return the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to return the shipping label
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{customer.GetName()}\n";
        label += customer.GetAddress().GetFullAddress();
        return label;
    }
}
