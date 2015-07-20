using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Exceptions;
using BLL.Interfaces.Services;
using DAL.Entites;
using DAL.Interfaces.Repositories;
using DAL.Interfaces.UnitOfWork;
using AutoMapper;
using BLL.Entites;

namespace BLL.Services
{
    public class DeviceService : IDeviceService
    {
        IDeviceRepository _deviceRepository;
        IUnitOfWork _unit;

        public DeviceService(IDeviceRepository deviceRepository, IUnitOfWork unit)
        {
           _deviceRepository = deviceRepository;
           _unit = unit;
           Mapper.CreateMap<Device, DalDevice>();
           Mapper.CreateMap<DalDevice, Device>();
        }
       
        public Device Create(Device device)
        {

            var dalDevice = AutoMapper.Mapper.Map<DalDevice>(device);
            var newDevice = _deviceRepository.Create(dalDevice);
               _unit.Commit();
            return AutoMapper.Mapper.Map<Device>(newDevice); 
           
        }

      
       
    }
}
