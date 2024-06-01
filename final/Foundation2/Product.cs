public class Product
{
    public int ProductId { get; set ; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice()
    {
        return Price * Quantity;
    }
}