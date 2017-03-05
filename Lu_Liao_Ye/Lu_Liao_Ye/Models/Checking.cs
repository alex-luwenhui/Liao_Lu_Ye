using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lu_Liao_Ye.Models
{
    public class Checking
    {
        public int CheckingID { get; set; }

        [Required]
        public string AccountName { get; set; } = "Longhorn Checking";

        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public decimal Balance { get; set; } = 0;
    }
}