using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Android_Push_Notifications.RestService.Responses
{
    [DataContract]
    [KnownType(typeof(SuccessResponse))]
    [KnownType(typeof(FailureResponse))]
    public class Response
    {
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}