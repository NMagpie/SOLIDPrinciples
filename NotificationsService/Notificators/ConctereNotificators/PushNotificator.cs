using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.NotificationsService.Users;

namespace _12._SOLID_principles.NotificationsService.Notificators.ConctereNotificators
{
    public class PushNotificator : INotificator
    {
        public void SendNotification(User sender, User receiver, Notification notification)
        {
            var device = receiver.Device;

            // some validation (idk)

            // getting some Push Notification API

            Console.WriteLine($"User[{sender.Id}] Sent notification via Device to User[{receiver.Id}][{receiver.Device}]: {notification.Message}\n");
        }
    }
}
