using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces.Services;
using DAL.Entites;
using DAL.Interfaces.Repositories;
using DAL.Interfaces.UnitOfWork;

namespace BLL.Services
{
    public class UserService: IUserService
    {
        IGenericRepository<User> _repository;
        IUnitOfWork _unit;

        public UserService(IGenericRepository<User> repository, IUnitOfWork unit)
        {
            _repository = repository;
            _unit = unit;
        }

        public User Create(User user)
        {
            var createdUser = _repository.Create(user);
            _unit.Commit();
            return createdUser;
        }
    }
}
