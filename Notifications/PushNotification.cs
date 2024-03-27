using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12._SOLID_principles.Notifications.Interfaces;

namespace _12._SOLID_principles.Notifications
{
    public class PushNotification(string message) : ANotification(message)
    {
        public override string Message { get => $"Push Notification: {_message}"; }
    }
}
