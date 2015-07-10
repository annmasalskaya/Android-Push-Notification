using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Entites;

namespace DAL.Repositories
{
    public class UserRepository: GenericRepository<User>
    {
        public UserRepository(DbContext context)
            : base(context)
        {

        }
    }
}
