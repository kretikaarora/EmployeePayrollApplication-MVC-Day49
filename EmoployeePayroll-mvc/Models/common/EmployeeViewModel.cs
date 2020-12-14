using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Models.common
{
    /// <summary>
    /// EmployeeViewModel class will contains fields of all the table to make suppose insert in all the table at a time
    /// </summary>
    public class EmployeeViewModel
    {
        public int EmpId { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int DepartmentId { get; set; }

        public string Department { get; set; }

        public string Amount { get; set; }

        public int SalaryId { get; set; }

        ///Specifies how date format should be displayed
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime StartDate { get; set; }

        public string Description { get; set; }
    }
}