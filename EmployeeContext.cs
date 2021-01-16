using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    internal class EmployeeContext : DbContext
    {
        private readonly string connectionString;
        public EmployeeContext(string con)
        {
            connectionString = con;
        }
        public DbSet<Employee> Employees  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString);
        }
    }
}
