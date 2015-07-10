using DAL.Entites.Entites;

namespace DAL.Entites.Repositories
{
    interface IDeviceRepository : IGenericRepository<BaseEntity>
    {
        BaseEntity GetBy(int userId);
    }
}
