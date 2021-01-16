using System;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new EmployeeProvider(new EmployeeContext(""));
            var employee = provider.Get(1);
            Console.WriteLine("Welcome");
        }
    }
}
