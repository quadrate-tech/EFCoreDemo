using System;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCon = new EmployeeContext();

            // provider = new EmployeeProvider(new EmployeeContext());

            //var employee = provider.Get(1);
            Console.WriteLine("Welcome");

            var repo = new EmployeeRepo(dbCon);
            repo.Create("Fazrin", "Farook", "Address", "123456789", "98765431");
        }
    }
}
