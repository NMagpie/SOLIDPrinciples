using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.NotificationsService.Users;

namespace _12._SOLID_principles.NotificationsService.Notificators
{
    public interface INotificator
    {
        public void SendNotification(User sender, User receiver, Notification notification);
    }
}
