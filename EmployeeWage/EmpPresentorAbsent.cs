using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpPresentorAbsent
    {
        public void Attendance()
        {
            int FULL_TIME = 1;
            Random r=new Random();
            int check=r.Next(0,2);
            if(check==1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
