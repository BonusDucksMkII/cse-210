public class Order
{
    public List<Product> ProductList { get; set; }
    public Customer OrderCustomer { get; set; }
    public double OrderTotal;
    public Order (List<Product> productList, Customer ordCust)
    {
        ProductList = productList;
        OrderCustomer = ordCust;

        foreach (Product prod in ProductList)
        {
            OrderTotal += prod.Quantity * prod.Price;
        }

        if (!OrderCustomer.CheckForUsa())
        {
            OrderTotal += 35.0;
        }
    }

    public string GetPackingLabel()
    {
        string newStr =
        $"""
        {OrderCustomer.CustAddress.GetAddressLine()} 
        {OrderCustomer.Name}
        ===========================
        """;
        foreach (Product prod in ProductList)
        {
            newStr += $"\n{prod.ProductId}     ";
            newStr += $"      {prod.Price}     ";
            newStr += $"{prod.Quantity}\n";
            newStr += "-----------------------";
        }
        newStr += OrderCustomer.CheckForUsa() ? "\nFrom United States [x]" : "\nFrom United States [ ]";
        newStr += $"\n${OrderTotal}";
        return newStr;
    }

    public string GetShippingLabel()
    {
        string newStr = 
        $"""
        {OrderCustomer.CustAddress.GetAddressLine()}
        {OrderCustomer.Name}
        ===============================
                0 lbs. 0 oz.
            Barcode/carrier stuff
        ===============================
        """;
        return newStr;
    }
}