﻿using DAL.Interfaces.Entites;

namespace DAL.Entites
{
    public class Device : BaseEntity
    {
        public int UserID { get; set; }

        public string RegistrationId { get; set; }
        
        public string Imei { get; set; }
    }
}