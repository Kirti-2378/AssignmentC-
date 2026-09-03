using System;

class Employee
{
    public string Name { get; set; }
    public double BasicSalary { get; set; }
    public int Experience { get; set; }

    public double Bonus
    {
        get
        {
            if (Experience >= 10)
                return BasicSalary * 0.20;
            else if (Experience >= 5)
                return BasicSalary * 0.10;
            else
                return BasicSalary * 0.05;
        }
    }
}

class Program1
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.Name = "Kartik";
        emp.BasicSalary = 50000;
        emp.Experience = 8;

        Console.WriteLine("Name: " + emp.Name);
        Console.WriteLine("Basic Salary: " + emp.BasicSalary);
        Console.WriteLine("Experience: " + emp.Experience + " years");
        Console.WriteLine("Bonus: " + emp.Bonus);
    }
}