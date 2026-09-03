using System;

public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public double DiscountPrice
    {
        get
        {
            if (Price >= 10000)
                return Price - (Price * 0.20);
            else if (Price >= 5000)
                return Price - (Price * 0.10);
            else
                return Price;
        }
    }
}

public class DiscountProduct
{
    public static void Main1(string[] args)
    {
        Product product = new Product();

        product.ProductName = "Laptop";
        product.Price = 12000;

        Console.WriteLine("Product Name: " + product.ProductName);
        Console.WriteLine("Original Price: " + product.Price);
        Console.WriteLine("Final Price: " + product.DiscountPrice);
    }
}