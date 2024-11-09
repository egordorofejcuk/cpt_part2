using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ColculateSum
    {
        public decimal CalculateSalary(Employee employee)
        {
            return employee.TimeWorked * employee.HourlyRate;
        }

    }
}
