using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_2
{
    internal class Shopping
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
        public double Discount
        {
            get
            {

                if (TotalPrice >= 10000)
                    return TotalPrice * 0.15;
                else if (TotalPrice >= 5000)
                    return TotalPrice * 0.10;
                else
                    return 0;
            }
        }
        public double FinalPrice
        {
            get
            {
                return TotalPrice - Discount;
            }
        }
    }
    class Program2
    {
        static void Main2(string[] args)
        {
            Shopping shopping = new Shopping();
            shopping.ProductName = "Smartphone";
            shopping.Quantity = 3;
            shopping.Price = 4000;
            Console.WriteLine("Product Name: " + shopping.ProductName);
            Console.WriteLine("Quantity: " + shopping.Quantity);
            Console.WriteLine("Price per Unit: " + shopping.Price);
            Console.WriteLine("Total Price: " + shopping.TotalPrice);
            Console.WriteLine("Discount: " + shopping.Discount);
            Console.WriteLine("Final Price: " + shopping.FinalPrice);
        }
    }
}
