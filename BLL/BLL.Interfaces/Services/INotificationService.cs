using DAL.Entites;

namespace BLL.Interfaces.Services
{
    public interface INotificationService
    {
        void sendNotification(Device device, string message);
    }
}
