using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entites;

namespace BLL.Interfaces.Services
{
    public interface IDeviceService
    {
         Device Create(Device device, User user);
         IEnumerable<Device> GetAllByUser(User user);
    }
}
