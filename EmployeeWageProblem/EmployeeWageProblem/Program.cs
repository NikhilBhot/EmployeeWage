﻿namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-01-  Check Employee is Present or Absent
            //UC-02-Calculate Daily Employee Wage
            Console.WriteLine("Wel-Come To Employee Wage Problem");
            //Constants
            int IS_FULL_TIME=1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs=0;
            int empWage=0;

            Random random = new Random(); 
            //Computation

            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)

            {
                empHrs=8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs *EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : "+ empWage);
        }
    }
}