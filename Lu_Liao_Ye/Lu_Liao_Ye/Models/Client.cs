using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lu_Liao_Ye.Models
{
    public class Client
    {
        [Required]
        public int ClientID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }




    }
}