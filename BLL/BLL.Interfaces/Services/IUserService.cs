using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Entites;

namespace BLL.Interfaces.Services
{
    public interface IUserService
    {
         IEnumerable<User> GetAll();
         User Create(User user, string Password);
         User GetBy(string login);
        

    }
}
