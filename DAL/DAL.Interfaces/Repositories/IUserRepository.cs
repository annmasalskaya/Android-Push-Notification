using DAL.Interfaces.Entites;

namespace DAL.Interfaces.Repositories
{
    interface IUserRepository : IGenericRepository<BaseEntity>
    {
        BaseEntity GetBy(string login);
    }
}
