using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Android_Push_Notifications.Models
{
    public class User
    {
        [Required]
        [Key]
        public int userId { get; set; }

        [Required]
        [Display(Name = "Login")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Login must be from 3 to 50 symbols")]
        [DataType(DataType.Text)]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

       
    }
}