using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Exceptions;
using BLL.Interfaces.Services;
using DAL.Entites;
using DAL.Repositories;
using DAL.Interfaces.UnitOfWork;

namespace BLL.Services
{
    public class DeviceService : IDeviceService
    {
        DeviceRepository _deviceRepository;
        UserRepository _userRepository;
        IUnitOfWork _unit;

        public DeviceService(DeviceRepository deviceRepository, UserRepository userRepository, IUnitOfWork unit)
        {
            _deviceRepository = deviceRepository;
            _userRepository = userRepository;
            _unit = unit;
        }

        //TODO use DeviceViewModel ?
        public Device Create(Device device, User owner)
        {
            var user = _userRepository.GetBy(owner.Login);
            if(user!=null)
            {
               var newDevice = new Device {
                   RegistrationId = device.RegistrationId,
                   Imei = device.Imei,
                   UserId = owner.Id
               };
               newDevice = _deviceRepository.Create(newDevice);
               _unit.Commit();
               return newDevice;
            }
            else
            {
                throw new UserNotExistException();
            }
        }

        // TODO List<Device> ?
        public IEnumerable<Device> GetAllByUser(User user)
        {
            return _deviceRepository.GetBy(user.Id).ToList();
        }
    }
}
