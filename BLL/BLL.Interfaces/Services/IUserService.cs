using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entites;

namespace BLL.Interfaces.Services
{
    public interface IUserService
    {
         User Create(User user);
    }
}
