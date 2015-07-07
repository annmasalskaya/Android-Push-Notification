using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DeviceService
{
    public class DeviceService: IDeviceService
    {
        public string RegisterDevice(DeviceInfoContract deviceInfo)
        {
            throw new NotImplementedException();
        }
    }
}
