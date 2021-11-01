using System;

namespace EmployeePayrollUsingThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiThreading multi = new MultiThreading();
            multi.AddEmployeeDetails();
            // multi.AddEmployeeDetailsUsingThreads();
             int result = multi.EmployeeCount();
            Console.WriteLine(result);
            multi.UpdateEmployee(1);

        }
    }
}
