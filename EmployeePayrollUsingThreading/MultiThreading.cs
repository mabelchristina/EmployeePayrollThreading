using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using System.Threading;


namespace EmployeePayrollUsingThreading
{
    public class MultiThreading
    {
        public EmployeeModel[] employeeDetails;
        public void AddEmployeeDetails()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            this.employeeDetails = new EmployeeModel[]
            {
                new EmployeeModel(EmployeeID:1,EmployeeName:"Mabel",PhoneNumber:"7410852096",
                Address:"Bangalore",Department:"IT",Gender:'F',BasicPay:1000,Deductions:200,TaxablePay:150,
                Tax:200,NetPay:400,City:"Banglore",Country:"India"),

                new EmployeeModel(EmployeeID:2,EmployeeName:"Sam",PhoneNumber:"8527419630",
                Address:"Chennai",Department:"HR",Gender:'M',BasicPay:1000,Deductions:200,TaxablePay:200,
                Tax:100,NetPay:400,City:"Chennai",Country:"India")
            };
            this.Display();
            stopwatch.Stop();
            Console.WriteLine("Time taken "+stopwatch.Elapsed);
        }
        public void AddEmployeeDetailsUsingThreads()
        {
            Stopwatch stopwatch = new Stopwatch();
            MultiThreading multiThreading = new MultiThreading();
            Thread thr = new Thread(new ThreadStart(multiThreading.AddEmployeeDetails));
            thr.Start();
        }
        public int EmployeeCount()
        {
            return this.employeeDetails.Length;
        }
        public void Display()
        {
            foreach (EmployeeModel employee in this.employeeDetails)
            {
                Console.WriteLine(employee.EmployeeID + " " + employee.EmployeeName + " " + employee.PhoneNumber 
                    + " " + employee.Address + " " + employee.Department + " " + employee.BasicPay);
            }
        }
        public EmployeeModel UpdateEmployee(int id)
        {
            foreach (EmployeeModel employee in this.employeeDetails)
            {
                if (employee.EmployeeID == id)
                {
                    employee.BasicPay = 1500;
                    return employee;
                }
            }
            this.Display();
            return null;
        }
    }
}
