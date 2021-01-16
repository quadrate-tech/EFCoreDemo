using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    internal class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-02RK9HN\QUADRATESQL;Initial Catalog=project;Integrated Security=True");
        }
    }
}
