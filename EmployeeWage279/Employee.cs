using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage279
{
    public class Employee
    {
        public static void EmployeeInfo()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present Full Time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Present Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            int empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employe Daily Wage is: "+empWage);
        }
    }
}
