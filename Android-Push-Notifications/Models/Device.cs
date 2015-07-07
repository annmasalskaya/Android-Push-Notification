using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Android_Push_Notifications.Models
{
    public class Device
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "UserId")]
        public int userID { get; set; } 
        
       
        [Required]
        [DataType(DataType.Text)]
        public string RegistrationId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Imei { get; set; }
    }
}