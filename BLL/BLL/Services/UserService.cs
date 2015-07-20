using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces.Services;
using DAL.Entites;
using DAL.Interfaces.Repositories;
using DAL.Interfaces.UnitOfWork;
using BLL.Entites;
using AutoMapper;

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
            Mapper.CreateMap<User, DalUser>();
            Mapper.CreateMap<DalUser, User>();
        }

        public IEnumerable<User> GetAll()
        {
            var dalUsers = _repository.GetAll();
            var users = AutoMapper.Mapper.Map<IEnumerable<DalUser>, IEnumerable<User>>(dalUsers);
            return users;
        }


        public User GetBy(string login)
        {
            var dalUser = _repository.GetBy(login);
            var user = AutoMapper.Mapper.Map<User>(dalUser);
            return user;
        }

        public User Create(User user,string Password)
        {
            var dalUser = AutoMapper.Mapper.Map<DalUser>(user);
            dalUser.Password = Password;
            var createdUser = _repository.Create(dalUser);
            _unit.Commit();
            return AutoMapper.Mapper.Map<User>(createdUser);
        }
    }
}
