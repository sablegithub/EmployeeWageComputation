// See https://aka.ms/new-console-template for more information
namespace EmployeeWage
{
    class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("welcome to employee wage computation program");
            EmpPresentorAbsent E = new EmpPresentorAbsent();
            E.Attendance();
            EmployeeWage E1 = new EmployeeWage();
            E1.wage();
            PartTimeorFullTime T =new PartTimeorFullTime();
            T.CheckEmpFullOrPartTime();
            SwitchCase SC=new SwitchCase();
            SC.EmpWageSwitchCase();
        }
    }
}