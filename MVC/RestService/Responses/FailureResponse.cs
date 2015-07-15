using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Android_Push_Notifications.RestService.Responses
{
    [DataContract]
    public class FailureResponse : Response
    {
        public FailureResponse()
        {
            IsSuccess = false;
            Message = "Invalid user login";
        }
    }
}