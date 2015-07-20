using System.Collections.Generic;
using DAL.Entites;

namespace DAL.Interfaces.Repositories
{
    public interface IDeviceRepository: IGenericRepository<DalDevice>
    {
      //  IEnumerable<Device> GetBy(int userId);
    }
}
