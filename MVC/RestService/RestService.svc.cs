using BLL.Interfaces.Services;
using DAL.Entites;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Android_Push_Notifications.RestService.Responses;

namespace Android_Push_Notifications.RestService
{
    public class RestService : IRestService
    {
        // [Inject]
        IDeviceService _deviceService;
        //[Inject]
        IUserService _userService;

        public RestService(IDeviceService deviceService, IUserService userService)
        {
            _deviceService = deviceService;
            _userService = userService;

        }
         //URL POST :   http://localhost:50538/RestService/RestService.svc/RegisterDevice
        public Response RegisterDevice(DeviceInfoContract deviceInfo)
        {
            var user = _userService.GetBy(deviceInfo.UserLogin);
            if (user != null)
            {
                var newDevice = new Device
                {
                    RegistrationId = deviceInfo.RegistrationId,
                    Imei = deviceInfo.Imei,
                    UserId = user.Id
                };
                _deviceService.Create(newDevice);
                return new SuccessResponse();
            }
            else
            {
                return new FailureResponse();
            }
        }
    }
}
