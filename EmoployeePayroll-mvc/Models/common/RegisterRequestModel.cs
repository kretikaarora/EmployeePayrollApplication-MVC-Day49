using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Models.common
{
    /// <summary>
    /// This class is used for validating all the fields
    /// </summary>
    public class RegisterRequestModel
    {
        public int EmpId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name max length is 20 characters")]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string SalaryId { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime StartDate { get; set; }

        public string Description { get; set; }
    }
}