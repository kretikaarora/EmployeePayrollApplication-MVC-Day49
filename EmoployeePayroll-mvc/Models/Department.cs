using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Models
{
    public class Department
    {
        /// DeptId is the primary key and auto generated 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}