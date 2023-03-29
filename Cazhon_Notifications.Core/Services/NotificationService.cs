using Cazhon_Notifications.Core.Interfaces.Repositories;
using Cazhon_Notifications.Core.Interfaces.Services;
using Cazhon_Notifications.Core.Models;
using Cazhon_Notifications.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Core.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _NotificationRepository;

        public NotificationService(INotificationRepository NotificationRepository)
        {
            _NotificationRepository = NotificationRepository ?? throw new ArgumentNullException(nameof(NotificationRepository));

        }
        public async Task<NotificationResponse<IEnumerable<Notifications>>> GetNotifications()
        {
            return await _NotificationRepository.GetNotification();
        }

        public async Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification(string id)
        {
            return await _NotificationRepository.GetNotification();
        }



    }
}
