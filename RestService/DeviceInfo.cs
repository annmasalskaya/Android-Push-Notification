using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
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