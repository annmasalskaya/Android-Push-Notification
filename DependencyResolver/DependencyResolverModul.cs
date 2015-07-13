using System;
using System.Collections.Generic;
using System.Data.Entity;
using Ninject.Modules;
using Ninject.Web.Common;
using DAL.Interfaces.Repositories;
using DAL.Interfaces.UnitOfWork;
using DAL.Repositories;
using DAL.UnitOfWork;
using DAL.ApplicationDbContext;
using BLL.Interfaces.Services;
using BLL.Services;

namespace DependencyResolver
{
    public class DependencyResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<IDeviceService>().To<DeviceService>();

            Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            Bind<IDeviceRepository>().To<DeviceRepository>().InRequestScope();

            Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            Bind<DbContext>().To<ApplicationDbContext>().InRequestScope();
        }
    }
}
