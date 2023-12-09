using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetCustomerName("Daniel Castro");
        order1.SetAddress("main st", "bigtown", "Utah", "USA");

        Product product1 = new Product("SkullCandy Earbuds", 101, 12.99, 1);
        Product product2 = new Product("Mistborn - Brandon Sanderson", 102, 25.00, 2); 
        Product product3 = new Product("Black licorice", 103, 4.99, 6); 

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine($"Packing Label\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order1.GetTotalCost()}\n");


        Order order2 = new Order();
        order2.SetCustomerName("John Doe");
        order2.SetAddress("Maple court", "Smallville", "Santiago", "Chile");

        Product product4 = new Product("Santa hat", 201, 2.59, 3);
        Product product5 = new Product("Kindle Fire", 202, 174.99, 1); 
        Product product6 = new Product("Sticker pack", 203, 9.99, 2); 

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine($"Packing Label\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetTotalCost()}\n");
    }
}