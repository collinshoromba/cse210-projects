using System;

class Program
{
    static void Main(string[] args)
    {
         // Creating address and customer
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer usaCustomer = new Customer("John Doe", usaAddress);

        // Creating products
        Product product1 = new Product("Laptop", 1, 800, 2);
        Product product2 = new Product("Mouse", 2, 20, 3);

        // Creating an order with products and a USA customer
        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(order1Products, usaCustomer);

        // Displaying information for the first order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        // Creating address and customer outside the USA
        Address internationalAddress = new Address("456 Street Ave", "Townsville", "NSW", "Australia");
        Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);

        // Creating more products
        Product product3 = new Product("Headphones", 3, 50, 1);
        Product product4 = new Product("External Hard Drive", 4, 100, 1);

        // Creating an order with international customer
        List<Product> order2Products = new List<Product> { product3, product4 };
        Order order2 = new Order(order2Products, internationalCustomer);

        // Displaying information for the second order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}