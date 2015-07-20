using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Interfaces.Repositories;
using DAL.Entites;

namespace DAL.Repositories
{
    public class DeviceRepository : GenericRepository<DalDevice>, IDeviceRepository
    {
        public DeviceRepository(DbContext context)
            : base(context)
        {

        }

     
    }
}
