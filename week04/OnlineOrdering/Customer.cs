public class Customer
{
    private string name;
    private Address address;

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return this.address.IsInUSA();
    }

    // Getter method for the customer's name
    public string GetName()
    {
        return this.name;
    }

    // Getter method for the customer's address
    public Address GetAddress()
    {
        return this.address;
    }
}
