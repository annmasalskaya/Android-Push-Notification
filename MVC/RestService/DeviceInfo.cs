using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Android_Push_Notifications.RestService
{
    [DataContract]
    public class DeviceInfoContract
    {
        [DataMember]
        public string UserLogin { get; set; }

        [DataMember]
        public string RegistrationId { get; set; }

        [DataMember]
        public string Imei { get; set; }
    }
}