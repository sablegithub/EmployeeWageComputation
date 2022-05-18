using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class SaveTotalWage
    {
        public int PART_TIME = 1;
        public int FULL_TIME = 2;

        public string Name;
        public int emp_rate_Per_hour;
        public int No_Working_Days;
        public int Max_hour_Per_Month;
        public int Total_Empwage;
        public SaveTotalWage(String Name, int emp_rate_Per_hour, int No_Working_Days, int Max_hour_Per_Month)
        {
            this.Name = Name;
            this.emp_rate_Per_hour = emp_rate_Per_hour;
            this.No_Working_Days = No_Working_Days;
            this.Max_hour_Per_Month = Max_hour_Per_Month;
        }
             public void ComputeWage()
            {
                int Emphours = 0, Totalemphours = 0, TotalWorkingdays = 0;

                while (Totalemphours <= this.Max_hour_Per_Month && TotalWorkingdays < this.No_Working_Days)
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
                    Console.WriteLine("Day#:" + TotalWorkingdays + "Emp Hours :" + Emphours);
                }
                Total_Empwage = Totalemphours * this.emp_rate_Per_hour;
                Console.WriteLine("Total Employee Wage for : " + Name + " is " + Total_Empwage);
               //return this.Name + "" + this.Total_Empwage;
            }

        
    }
   
        
    


}
