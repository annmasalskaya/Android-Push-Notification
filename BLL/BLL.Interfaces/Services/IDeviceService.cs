using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entites;

namespace BLL.Interfaces.Services
{
    public interface IDeviceService
    {
        public Device Create(Device device, User user);
    }
}
