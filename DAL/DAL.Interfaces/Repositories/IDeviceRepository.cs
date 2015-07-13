using DAL.Entites;
using DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL.Interfaces.Repositories
{
    interface IDeviceRepository : IGenericRepository<Device>
    {
         IEnumerable<Device> GetBy(int userId);
    }
}
