using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("21 Baker Str.", "New York", "NY", "USA");
        Customer customer1 = new Customer("Arthur Doyle", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LT-101", 1200, 1));
        order1.AddProduct(new Product("Wireless-Mouse", "WM-102", 40, 2));
        order1.AddProduct(new Product("Wireless-Keyboard", "WK-103", 85, 1));

        Address address2 = new Address("Bahnhofstrasse 1", "Zurich", "ZH", "Switzerland");
        Customer customer2 = new Customer("Anna Müller", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Portable-Phone", "PP-201", 950, 1));
        order2.AddProduct(new Product("Phone-Charger", "PC-202", 25, 2));

        Console.WriteLine("= ORDER 1 =");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("= ORDER 2 =");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}

//no extra code