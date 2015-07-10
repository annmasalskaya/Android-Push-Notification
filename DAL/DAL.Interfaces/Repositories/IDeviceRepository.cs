using DAL.Interfaces.Entites;

namespace DAL.Interfaces.Repositories
{
    interface IDeviceRepository : IGenericRepository<BaseEntity>
    {
        BaseEntity GetBy(int userId);
    }
}
