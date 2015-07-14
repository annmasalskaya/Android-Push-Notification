using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entites;

namespace BLL.Interfaces.Services
{
    public interface IUserService
    {
         IEnumerable<User> GetAll();
         User Create(User user);
         User GetBy(string login);
        

    }
}
