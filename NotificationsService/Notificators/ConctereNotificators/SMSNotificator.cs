using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.NotificationsService.Users;

namespace _12._SOLID_principles.NotificationsService.Notificators.ConctereNotificators
{
    public class SMSNotificator : INotificator
    {
        public void SendNotification(User sender, User receiver, Notification notification)
        {
            var telNumber = receiver.TelNumber;

            // some validation

            // invoking some API, some actions

            Console.WriteLine($"User[{sender.Id}] Sent notification via SMS to User[{receiver.Id}][{receiver.TelNumber}]: {notification.Message}\n");
        }
    }
}
