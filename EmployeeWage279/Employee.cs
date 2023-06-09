﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage279
{
    public class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int No_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public static void EmployeeInfo()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs<= MAX_WORKING_HRS&& totalWorkingDays<=No_OF_WORKING_DAYS) {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present Full Time");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays+"Employee Hrs: "+empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total Employee Wage is: "+totalEmpWage);
        }
    }
}
