using EmployeePayrollUsingThreading;
using NUnit.Framework;
using System.Diagnostics;

namespace EmployeePayrollThreadTest
{
    public class Tests
    {
        MultiThreading multi = new MultiThreading();
        [Test]
        public void AddedMultipleEmployeeAndGetCount()
        {
           
            multi.AddEmployeeDetails();
            multi.AddEmployeeDetailsUsingThreads();
            int result = multi.EmployeeCount();
            Assert.AreEqual(2, result);
        }
        [Test]
        public void UpdateSalaryToMultipleEmployees()
        {
            Stopwatch stopwatch = new Stopwatch();
            multi.AddEmployeeDetails();
            stopwatch.Start();
            var result = multi.UpdateEmployee(1);
            multi.AddEmployeeDetailsUsingThreads();
            Assert.AreEqual(1500, result.BasicPay);
        }
    }
}