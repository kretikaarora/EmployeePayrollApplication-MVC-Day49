﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Models
{
    public class Salary
    {
        /// SalaryId is the primary key here and it is auto generated 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaryId { get; set; }
        public string Amount { get; set; }
    }
}