using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
   public class EmployeeWage
    {

        int FULL_TIME = 1;
        int EMP_HOUR = 20;
        int emphour = 0;
        int empWage = 0;
        

        public void wage()
        {
            Random r = new Random();
            int check = r.Next(0, 2);
            if (check == FULL_TIME)
            {
                emphour = 8;

            }
            else
            {
                emphour = 0;
            }
            empWage = emphour * EMP_HOUR;
            Console.WriteLine(emphour);
        }
    }
}
