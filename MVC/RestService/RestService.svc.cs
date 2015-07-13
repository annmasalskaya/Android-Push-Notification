using BLL.Interfaces.Services;
using DAL.Entites;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Android_Push_Notifications
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
         //в браузере :  http://localhost:50538/RestService/RestService.svc/RegisterDevice
        public string RegisterDevice()
        {
            var deviceInfo = new DeviceInfoContract
            {
                RegistrationId = "asza",
                Imei = "adfvcs",
                UserLogin = "AZazaza"
            };
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
                string json = JsonConvert.SerializeObject(new ResponseModel() { IsSuccess = true, Message = "Added successfully." });
                return json;
            }
            else
            {
                return JsonConvert.SerializeObject(new ResponseModel() { IsSuccess = false, Message = "User doesn't exist" });
            }
        }



    }
}
