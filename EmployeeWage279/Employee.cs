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
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
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
