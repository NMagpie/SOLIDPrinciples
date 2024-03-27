namespace _12._SOLID_principles.Notifications.Interfaces
{
    public interface INotifyable
    {
        public void Notify(ANotification notification, object? sender = null);
    }
}
