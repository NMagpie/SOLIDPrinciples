using _12._SOLID_principles.Notifications.Interfaces;

namespace _12._SOLID_principles.Users
{
    public abstract class AUser(int id) : INotifyable, INotificator<AUser>
    {
        public int Id { get; set; } = id;

        public void Notify(ANotification notification, object? sender = null)
        {
            Console.WriteLine($"User [{Id}] has {notification.Message}");
        }

        public void SendNotification(AUser receiver, ANotification notification)
        {
            Console.WriteLine($"User [{Id}] has send {notification.Message} to [{receiver.Id}]");
            receiver.Notify(notification);
        }
    }
}
