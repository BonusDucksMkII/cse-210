public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public string GetAddressLine()
    {
        return $"{Street}, {City}; {State}, {Country}";
    }

    internal bool IsUsa()
    {
        if (Country.ToUpper() == "USA" || Country.ToUpper() == "UNITED STATES")
        {
            return true;
        }

        return false;
    }
}