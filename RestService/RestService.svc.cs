using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
{
    public class RestService: IRestService
    {
        public string RegisterDevice(DeviceInfoContract deviceInfo)
        {
            throw new NotImplementedException();
        }
    }
}
