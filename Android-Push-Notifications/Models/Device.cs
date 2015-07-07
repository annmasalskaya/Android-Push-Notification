using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Android_Push_Notifications.Models
{
    public class Device
    {
        [Required]
        [Key]
        public int deviceId { get; set; }

        [Required]
        [Display(Name = "UserId")]
        public int userID { get; set; }

        [ForeignKey("userID")]
        public virtual User User { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string RegistrationId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Imei { get; set; }
    }
}