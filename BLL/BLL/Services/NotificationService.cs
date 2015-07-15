using System;
using System.IO;
using System.Text;
using System.Configuration;
using System.Net;
using BLL.Interfaces.Services;
using DAL.Entites;

namespace BLL.Services
{
    public class NotificationService : INotificationService
    {
        string appId;
        string senderId;
        string gcmUrl;
        string gcmMethod;
        string gcmContentType;

        public NotificationService(){
            appId = ConfigurationManager.AppSettings["application_id"];
            senderId = ConfigurationManager.AppSettings["sender_id"];
            gcmMethod = ConfigurationManager.AppSettings["gcm_url"];
            gcmMethod = ConfigurationManager.AppSettings["gcm_method"];
            gcmContentType = ConfigurationManager.AppSettings["gcm_content_type"];
        }
        
        public void sendNotification(Device device, string message)
        {
            WebRequest request = WebRequest.Create(gcmUrl);

            request.Method = gcmMethod;
            request.ContentType = gcmContentType;
            request.Headers.Add(string.Format("Authorization: key={0}", appId));
            request.Headers.Add(string.Format("Sender: id={0}", senderId));

            string postData = "collapse_key=score_update&" + 
                "time_to_live=108" +
                "&delay_while_idle=1" + 
                "&data.message=" + message +
                "&data.time=" + System.DateTime.Now.ToString() +
                "registration_id=" + device.RegistrationId + "";

            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            /* For getting serer response uncoment this line and use
             * responseFromeServer string as you wish
             * 
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            String responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();
            */
        }
    }
}
