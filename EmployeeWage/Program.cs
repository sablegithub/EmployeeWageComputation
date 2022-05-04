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
        }
    }
}