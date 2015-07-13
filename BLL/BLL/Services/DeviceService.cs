using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Exceptions;
using BLL.Interfaces.Services;
using DAL.Entites;
using DAL.Interfaces.Repositories;
using DAL.Interfaces.UnitOfWork;

namespace BLL.Services
{
    public class DeviceService : IDeviceService
    {
        IDeviceRepository _deviceRepository;
        IUserRepository _userRepository;
        IUnitOfWork _unit;

        public DeviceService(IDeviceRepository deviceRepository, IUserRepository userRepository, IUnitOfWork unit)
        {
            _deviceRepository = deviceRepository;
            _userRepository = userRepository;
            _unit = unit;
        }
        //TODO use DeviceViewModel ?
        public Device Create(Device device)
        {
            
               var newDevice = _deviceRepository.Create(device);
               _unit.Commit();
               return newDevice;
           
        }

        // TODO List<Device> ?
        public IEnumerable<Device> GetAllByUser(User user)
        {
            return _deviceRepository.GetBy(user.Id).ToList();
        }
    }
}
