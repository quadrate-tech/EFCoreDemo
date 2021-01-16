using System;

namespace EFCoreDemo
{
    class Program
    {
        public static EmployeeContext empContext = new EmployeeContext();
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome");

            //var repo = new EmployeeRepo(empContext);
            //repo.Create("Fazrin", "Farook", "Address", "123456789", "98765431");
        }

        public static Employee Create(string firstName, string lastName, string address, string homePhone, string cellPhone)
        {
            var data = empContext.Add(new Employee { FirstName = firstName, LastName = lastName, Address = address, HomePhone = homePhone, Mobile = cellPhone });
            empContext.SaveChanges();
            return data.Entity;
        }

        public static void Delete(Employee emp)
        {
            empContext.Remove(emp);
            empContext.SaveChanges();
        }


        public static Employee Update(Employee employee)
        {
            var data = empContext.Update(employee);
            empContext.SaveChanges();
            return data.Entity;
        }

    }
}
