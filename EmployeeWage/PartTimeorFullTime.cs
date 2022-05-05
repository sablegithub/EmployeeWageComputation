using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class PartTimeorFullTime
    {

        public void CheckEmpFullOrPartTime()
        {
            bool FULL_TIME;
            Random r= new Random();
            int check = r.Next(0, 2);
            if (check==1)
            {
                FULL_TIME = true;
                Console.WriteLine("Full Time Employee ");
            }
            else
            {
                FULL_TIME = false;
                Console.WriteLine("Part Time Employee ");
            }
        }
    }
}
