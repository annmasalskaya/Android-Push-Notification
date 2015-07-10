using DAL.Entites.Entites;

namespace DAL.Entites.Repositories
{
    interface IUserRepository: IGenericRepository<BaseEntity>
    {
        BaseEntity GetBy(string login);
    }
}
