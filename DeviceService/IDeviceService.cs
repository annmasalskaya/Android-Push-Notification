using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DeviceService
{
    [ServiceContract]
    public interface IDeviceService
    {
        [OperationContract]
        [WebInvoke(Method="GET",
            ResponseFormat=WebMessageFormat.Json,
            BodyStyle=WebMessageBodyStyle.Wrapped,
            UriTemplate="RegisterDevice")]
        string RegisterDevice(DeviceInfoContract deviceInfo);
    }
}
