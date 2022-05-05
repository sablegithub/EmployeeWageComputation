using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Wage_MAX_DAY
    {

        int Emphours = 0;
        int EmpWage = 0;
        int Total_Empwage = 0;
        int EMP_RATE_PER_HOUR = 20;
        int NUM_WORKING_DAY = 2;
        int MAX_HOUR_MONTH = 10;
        int Totalemphours = 0;
        int TotalWorkingdays = 0;



        public void Wage_Month()
        {
            while(Totalemphours <= MAX_HOUR_MONTH  &&  TotalWorkingdays < NUM_WORKING_DAY)
            {
                TotalWorkingdays++;
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
                Totalemphours += Emphours;
                Console.WriteLine("Day: " +  TotalWorkingdays +  "Emp Hours :" + Emphours);
            }
             Total_Empwage = Totalemphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage:" + Total_Empwage);
        }

    }
}

