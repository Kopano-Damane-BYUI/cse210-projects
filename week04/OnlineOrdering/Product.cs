public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    // Constructor to initialize product details
    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of this product
    public double GetTotalCost()
    {
        return this.price * this.quantity;
    }

    // Getter method for the product name
    public string GetName()
    {
        return this.name;
    }

    // Getter method for the product ID
    public int GetProductId()
    {
        return this.productId;
    }
}
