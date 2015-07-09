using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfacies.DTO
{
    class DalDevice : IEntity
    {
        
        public int Id { get; set; }

        public int userID { get; set; }

        public string RegistrationId { get; set; }
        
        public string Imei { get; set; }
    }
}
