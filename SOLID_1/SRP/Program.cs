using SRP;
using System;

namespace SRP
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Name", 300, 143);
            ColculateSum colculateSum = new ColculateSum();

            decimal salary = colculateSum.CalculateSalary(employee);
            Console.WriteLine($"Зарплата: {salary}");

        }
    }
}