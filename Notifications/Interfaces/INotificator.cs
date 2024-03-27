namespace _12._SOLID_principles.Notifications.Interfaces
{
    public interface INotificator<T> where T : INotifyable
    {
        public void SendNotification(T receiver, ANotification notification);
    }
}
