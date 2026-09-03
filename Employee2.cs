using System;

namespace MyApp
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }

        public double HRA
        {
            get { return BasicSalary * 20 / 100; }
        }

        public double DA
        {
            get { return BasicSalary * 10 / 100; }
        }

        public double GrossSalary
        {
            get { return BasicSalary + HRA + DA; }
        }

        public double Tax
        {
            get
            {
                if (GrossSalary > 100000) return GrossSalary * 20 / 100;
                else if (GrossSalary > 50000) return GrossSalary * 10 / 100;
                else return GrossSalary * 5 / 100;
            }
        }

        public double NetSalary
        {
            get { return GrossSalary - Tax; }
        }
    }

    class Program6
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.Write("Enter Employee ID: ");
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            emp.BasicSalary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Employee ID   : " + emp.EmployeeId);
            Console.WriteLine("Employee Name : " + emp.Name);
            Console.WriteLine("Basic Salary  : " + emp.BasicSalary);
            Console.WriteLine("HRA           : " + emp.HRA);
            Console.WriteLine("DA            : " + emp.DA);
            Console.WriteLine("Gross Salary  : " + emp.GrossSalary);
            Console.WriteLine("Tax           : " + emp.Tax);
            Console.WriteLine("Net Salary    : " + emp.NetSalary);
        }
    }
}