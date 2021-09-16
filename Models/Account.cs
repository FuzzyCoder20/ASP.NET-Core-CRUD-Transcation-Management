using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AWP_project_transactions.Models
{
    public class Account
    {

        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username
        {
            get;
            set;
        }

        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        [DataType(DataType.Password)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }


        [Required]
        [Range(18, 50)]
        public int Age
        {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }



    }
       
        
    
}
