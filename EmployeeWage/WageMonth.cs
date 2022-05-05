using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class WageMonth
    {
        int Emphours = 0;
        int EmpWage = 0;
        int Total_Empwage = 0;
        int EMP_RATE_PER_HOUR = 20;
        int NUM_WORKING_DAY = 2;


        public void Wage_Month()
        {
            for (int day = 0; day < NUM_WORKING_DAY; day++)
            {
                Random r = new Random();
                int check = r.Next(0, 3);
                switch (check)
                {
                    case 1:
                        Emphours = 4;
                        Console.WriteLine("Employe is Working as Part Time");
                        break;
                    case 2:
                        Emphours = 8;
                        Console.WriteLine("Employee is Working as Full Time");
                        break;
                    case 3:
                        Emphours = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                EmpWage = Emphours * EMP_RATE_PER_HOUR;
                Total_Empwage = +EmpWage;
                Console.WriteLine(" Employee Wage :" + EmpWage);
            }
            Console.WriteLine("Total Employee Wage:"+Total_Empwage);
        }
        
    }
}
