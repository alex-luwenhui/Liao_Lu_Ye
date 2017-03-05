using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Lu_Liao_Ye.Models
{
    public class ClientInfo
    {
        [Display(Name = "Client Info ID")]
        public int ClientInfoID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email address.")]
        [Display(Name = "Email Address")]
        [EmailAddress (ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }


        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set;}



    }
}