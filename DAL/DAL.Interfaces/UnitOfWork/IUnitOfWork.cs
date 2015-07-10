using System;

namespace DAL.Entites.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
