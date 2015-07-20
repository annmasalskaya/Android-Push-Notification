using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entites;
using BLL.Entites;

namespace BLL.Interfaces.Services
{
    public interface IDeviceService
    {
         Device Create(Device device);
         
    }
}
