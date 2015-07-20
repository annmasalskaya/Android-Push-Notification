using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entites
{
     public  class Device
    {
        public User User { get; set; }

        public string RegistrationId { get; set; }

        public string Imei { get; set; }
    }
}
