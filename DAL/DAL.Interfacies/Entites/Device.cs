﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfacies.Entites
{
    class Device : IEntity
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public string RegistrationId { get; set; }
        
        public string Imei { get; set; }
    }
}
