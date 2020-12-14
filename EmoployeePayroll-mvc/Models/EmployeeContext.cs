using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Models
{
    /// <summary>
    /// This class is used for connecting with the databaseand changes in the database
    /// EmployeeContext is derived from dbcontext
    /// </summary>
    public class EmployeeContext: DbContext
    {      
            ///Dbset is created from Dbcontext and it contains all the entities from the respective tables
            public DbSet<Employee> Employees { get; set; }

            public DbSet<Department> Departments { get; set; }

            public DbSet<Salary> Salaries { get; set; }
    }
}