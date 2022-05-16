using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Multiple_Companies
    {
        int Full_Time = 1;
        int PART_Time = 2;
        int Emphours = 0;
        int EmpWage = 0;
        int Total_Empwage=0;
        int TotalWorkingdays = 0;

        public void Company1()
        {
            int Working_Day = 20;
            int Working_Hours = 100;

            Random r = new Random();
            int check = r.Next(0, 3);
            if (check == Full_Time)
            {
                Console.WriteLine("Employee is Full Time Present");
                Emphours = 8;
                Console.WriteLine("Employee Wage is " + (EmpWage = Emphours * Working_Day));
            }
            else if (check == PART_Time)
            {
                Console.WriteLine("Employee is Part Time Present");
                Emphours = 4;
                Console.WriteLine("Employee Wage is " + (EmpWage = Emphours * Working_Day));
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
             
            Total_Empwage = Working_Hours * Working_Day;
            Console.WriteLine("Total Employee Wage:" + Total_Empwage);
        }

        int working_Day = 0;
        int working_Hours = 0;
        public void Company2(int Working_Day, int Working_Hours)
        {
            this.working_Hours = Working_Hours;
            this.working_Day = Working_Day;

            Random random= new Random ();
            int check=random.Next(0,3);
            if (check == Full_Time)
            {
                Console.WriteLine("Employee is Full Time Present");
                Emphours = 8;
                Console.WriteLine("Employee Wage is " + (EmpWage = Emphours * Working_Day));
            }
            else if (check == PART_Time)
            {
                Console.WriteLine("Employee is Part Time");
                Emphours = 4;
                Console.WriteLine("Employee Wage is " + (EmpWage = Emphours * Working_Day));
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
                Total_Empwage = Working_Hours * Working_Day;
                Console.WriteLine("Total EmpWage :" + Total_Empwage);
            
        }
        

    }
}
