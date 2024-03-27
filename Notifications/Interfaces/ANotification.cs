namespace _12._SOLID_principles.Notifications.Interfaces
{
    public abstract class ANotification(string message)
    {
        protected readonly string _message = message;

        public virtual string Message { get; } = message;
    }
}
