public class Product
{
    public int ProductId { get; set ; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(int id, double price, int qty)
    {
        ProductId = id;
        Price = price;
        Quantity = qty;
    }
}