using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.NotificationsService.Users;

namespace _12._SOLID_principles.NotificationsService.Notificators.ConctereNotificators
{
    public class EmailNotificator : INotificator
    {
        public void SendNotification(User sender, User receiver, Notification notification)
        {
            var email = receiver.Email;

            // some validation

            // invoking smtp client

            Console.WriteLine($"User[{sender.Id}] Sent notification via Email to User[{receiver.Id}][{receiver.Email}]: {notification.Message}\n");
        }
    }
}
