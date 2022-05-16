using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class SwitchCase
    {
        int  PART_TIME = 1;
        int FULL_TIME=2;
        int EMP_RATE_PER_HOUR = 20;

        public void EmpWageSwitchCase()
        {
            int Emphours = 0;
            int EmpWage = 0;
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
                    break ;
                case 3:
                    Emphours = 0;
                    Console.WriteLine("Employee is Absent");
                    break;

                  
            }
            EmpWage = Emphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :" + EmpWage);

        }
        
    }
}
