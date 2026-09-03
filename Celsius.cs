using System;

class Temperature
{
    private double celsius;

    public double Celsius
    {
        get
        {
            return celsius;
        }
        set
        {
            if (value < -273.15)
            {
                Console.WriteLine("Invalid temperature!");
            }
            else
            {
                celsius = value;
            }
        }
    }

    public double Fahrenheit
    {
        get
        {
            return (Celsius * 9 / 5) + 32;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Temperature temp = new Temperature();

        Console.Write("Enter Celsius: ");
        temp.Celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Celsius: " + temp.Celsius);
        Console.WriteLine("Fahrenheit: " + temp.Fahrenheit);
    }
}