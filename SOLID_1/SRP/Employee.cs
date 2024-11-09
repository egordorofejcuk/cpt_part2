using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public int TimeWorked { get; set; }

        public Employee(string name, decimal hourlyRate, int timeWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            TimeWorked = timeWorked;
        }
    }
}
