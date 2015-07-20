using BLL.Entites;
using DAL.Entites;

namespace BLL.Interfaces.Services
{
    public interface INotificationService
    {
        string sendNotification(Device device, string message);
    }
}
