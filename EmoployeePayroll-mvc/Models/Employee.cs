using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Models
{
    /// <summary>
    /// Employee Class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// These are all the fields in the database 
        /// we are using codefirst Approach here
        /// </summary>
        
        ///EmpId is the primary key and it will be auto incremented
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public int DepartmentId { get; set; }

        ///DepartmentId is the foreign key for Employee table 
        /// first Department is the datatype and second Department is refering to the Department table whose parameter is a foreign key
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public int SalaryId { get; set; }

        [ForeignKey("SalaryId")]
        public Salary Salary { get; set; }

        public DateTime StartDate { get; set; }

        public string Description { get; set; }
    }
}