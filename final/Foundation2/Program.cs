using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order
        (
            new List<Product>{new(12, 12.99, 1), new(1, 1.99, 3), new(56, 39.99, 2)},
            new Customer
            (
                "Chuck Berry",
                new Address
                (
                    "123 Sesame Street",
                    "Anytown",
                    "New Jersey",
                    "United States"
                )
            )
        );
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Total: ${order1.OrderTotal}");
        Console.WriteLine("\n\n");

        Order order2 = new Order
        (
            new List<Product>{new(99, 5.99, 4), new(54, 33.99, 2), new(4, 65.82, 3)},
            new Customer
            (
                "Albert Stork",
                new Address
                (
                    "4983 West 689 South Unit 586",
                    "Southend-on-Sea",
                    "Essex",
                    "United Kingdom"
                )
            )
        );
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Total: ${order2.OrderTotal}");
    }
}