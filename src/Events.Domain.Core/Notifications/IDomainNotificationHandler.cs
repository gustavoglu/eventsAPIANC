using Events.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Domain.Core.Notifications
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotification();
        List<T> GetNotifications();
    }
}
