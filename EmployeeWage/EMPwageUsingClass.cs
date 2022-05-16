using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{

    
    public class EMPwageUsingClass
    {
        const int FULL_TIME = 1;
        const int EMP_HOUR = 20;
        const int PART_TIME = 2;
        int emphour = 0;
        int empWage = 0;


        public void method()
        {
            Random r = new Random();
            int check = r.Next(0,3);
            if(check == FULL_TIME)
            {
                emphour = 8;
                Console.WriteLine("Full Time:"+(empWage=emphour*EMP_HOUR));
                

            }
            else if(check == PART_TIME)
            {
                emphour = 4;
                Console.WriteLine("Part Time :"+(empWage = emphour * EMP_HOUR));
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
           
        }
    }
}
