using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {

        int FULL_TIME = 1;
        int EMP_HOUR = 20;
        int emphour = 0;
        int empWage = 0;
        Random r = new Random();
        int check = r.Next(0, 2);

        public void wage()
        {
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
