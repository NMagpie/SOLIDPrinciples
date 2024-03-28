using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.NotificationsService.Notificators;
using _12._SOLID_principles.NotificationsService.Notificators.ConctereNotificators;
using _12._SOLID_principles.NotificationsService.Users;

namespace _12._SOLID_principles.NotificationsService
{
    public class NotificationService
    {

        private readonly Dictionary<ENotificators, INotificator> _notificators = new Dictionary<ENotificators, INotificator>()
            {
             { ENotificators.EmailNotificator, new EmailNotificator() },
             { ENotificators.PushNotificator, new PushNotificator() },
             { ENotificators.SMSNotificator, new SMSNotificator() },
        };

        /*        public void AddNotificator(ENotificators notificatorType, INotificator notificator)
                {
                    _notificators.Add(notificatorType, notificator);
                }*/

        public void Notify(User sender, User receiver, ENotificators notificationType, Notification notification)
        {
            _notificators[notificationType].SendNotification(sender, receiver, notification);
        }

        public void Notify(User sender, User receiver, Notification notification)
        {
            foreach (INotificator notificator in _notificators.Values)
            {
                notificator.SendNotification(sender, receiver, notification);
            }
        }

    }
}
