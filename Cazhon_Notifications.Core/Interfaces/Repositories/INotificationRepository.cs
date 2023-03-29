using Cazhon_Notifications.Core.Models;
using Cazhon_Notifications.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Core.Interfaces.Repositories
{
    public interface INotificationRepository
    {
        Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification();
        Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification(string id);

    }
}
