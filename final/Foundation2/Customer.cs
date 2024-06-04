public class Customer
{
    public string Name { get; set; }
    public Address CustAddress { get; set; }

    public Customer(string name, Address custAddress)
    {
        Name = name;
        CustAddress = custAddress;
    }

    public bool CheckForUsa()
    {
        return CustAddress.IsUsa();
    }
}