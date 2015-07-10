using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BLL.Entites;

namespace Android_Push_Notifications.Models
{
    public class UserModel: User
    {
        public int Id { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Length must be from 3 to 50 symbols")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}