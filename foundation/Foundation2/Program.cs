using System;

class Program
{
    static void Main(string[] args)
    {   

        Address adress01 = new Address("10 Jessie Street", "brampton", "Ontariom", "Canada");
        Customer customer01 = new Customer("Cristobal Henriquez", adress01);
        Product item01 = new Product("Organic Honey", 101, 12.99f, 2 );
        Product item02 = new Product("Almond Milk", 102, 3.49f, 5);
        Product item03 = new Product("Whole Wheat Bread", 103, 2.75f, 10);
        Order order01 = new Order(customer01);
        order01.addToCart(item01);
        order01.addToCart(item02);
        order01.addToCart(item03);
        

        Address adress02 = new Address("1251 Tinselberry Lane", "Whoville", "Alaska", "USA");
        Customer customer02 = new Customer("Cindy L. Who", adress02);
        Product item04 = new Product("Who Pudding", 104, 8.99f, 15);
        Product item05 = new Product("Roast Beast Slices", 105, 14.99f, 8);
        Product item06 = new Product("Grinch Nog", 106, 5.49f, 20);
        Order order02 = new Order(customer02);
        order02.addToCart(item04);
        order02.addToCart(item05);
        order02.addToCart(item06);

        Console.WriteLine(order01.PackingLabel());
        Console.WriteLine(order01.ShippingLabel());
        Console.WriteLine(order01.TotalCartCost());

        Console.WriteLine("\n-----------------------------------------------\n");

        Console.WriteLine(order02.PackingLabel());
        Console.WriteLine(order02.ShippingLabel());
        Console.WriteLine(order02.TotalCartCost());



    }
}