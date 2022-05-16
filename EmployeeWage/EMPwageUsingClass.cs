using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{

    public class Companies
    {
        public static int Company(String Name, int emp_rate_Per_hour, int No_Working_Days, int Max_hour_Per_Month)
        {
             int Totalemphours = 0;
             int TotalWorkingdays = 0;
             int Emphours = 0;
             int Total_Empwage = 0;

            while (Totalemphours <= Max_hour_Per_Month && TotalWorkingdays < No_Working_Days)
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
                Console.WriteLine("Day :" +TotalWorkingdays+  "Emp Hours :" + Emphours);
            }
            Total_Empwage = Totalemphours * emp_rate_Per_hour;
            Console.WriteLine("Total Employee Wage for : " + Name + " is " + Total_Empwage);
            return Total_Empwage;
        }

    }
}
