using Cazhon_Notifications.Core.Models;
using Cazhon_Notifications.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Core.Interfaces.Services
{
    public interface INotificationService
    {
        Task<NotificationResponse<IEnumerable<Notifications>>> GetNotifications();
        Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification(string id );
    }
}
