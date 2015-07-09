using DAL.Interfacies.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; private set; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            if (Context != null)
            {
                Context.SaveChanges();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}
