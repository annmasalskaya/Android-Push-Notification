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
        IUserRepository _repository;
        IUnitOfWork _unit;

        public UserService(IUserRepository repository, IUnitOfWork unit)
        {
            _repository = repository;
            _unit = unit;
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User Create(User user)
        {
            var createdUser = _repository.Create(user);
            _unit.Commit();
            return createdUser;
        }
    }
}
