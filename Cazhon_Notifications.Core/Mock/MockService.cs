using Cazhon_Notifications.Core.Interfaces.Services;
using Cazhon_Notifications.Core.Models;
using Cazhon_Notifications.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Core.Mock
{
    public class MockService : INotificationService
    {

        public async Task<NotificationResponse<IEnumerable<Notifications>>> GetNotifications()
        {
            List<Notifications> notifications = new List<Notifications>();
            Notifications notify = new Notifications();
            notify.NotificationimageName = "wow_wednesday.jpg";
            notify.NotificationimageURL = "https://s3.ap-south-1.amazonaws.com/www.cazhon.com/assets/images/notification/";
            notify.NotificationMessage = "This 24 - hour deal is coming in Hot! Browse our Deal of the Day.";
            notify.NotificationTitle = "CazhOn Days Deal";
            notify.UnreadMsgCount = "7";
            notifications.Add(notify);
            notify.NotificationimageName = "cazhon_giveaway.jpg";
            notify.NotificationimageURL = "https://s3.ap-south-1.amazonaws.com/www.cazhon.com/assets/images/notification/";
            notify.NotificationMessage = "Congrats! You won a giveway. Please contact our Team at contact@cazhon.co";
            notify.NotificationTitle = "CazhOn Giveaway";
            notify.UnreadMsgCount = "7";
            notifications.Add(notify);
            notify.NotificationimageName = "cashback_approved.jpg";
            notify.NotificationimageURL = "https://s3.ap-south-1.amazonaws.com/www.cazhon.com/assets/images/notification/";
            notify.NotificationMessage = "Congrats! You won super cool cashback on the shopping trip you made. Please visit myearnings/shopping tri";
            notify.NotificationTitle = "CazhOn Days Deal";
            notify.UnreadMsgCount = "7";
            notifications.Add(notify);
            await Task.Delay(0);
            NotificationResponse<IEnumerable<Notifications>> response = new NotificationResponse<IEnumerable<Notifications>>();
            response.Data = notifications;
            response.IsSuccess = true;
            return response;

        }

        public async Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification(string id)
        {
            List<Notifications> notifications = new List<Notifications>();
            Notifications notify = new Notifications();
            notify.NotificationimageName = "wow_wednesday.jpg";
            notify.NotificationimageURL = "https://s3.ap-south-1.amazonaws.com/www.cazhon.com/assets/images/notification/";
            notify.NotificationMessage = "This 24 - hour deal is coming in Hot! Browse our Deal of the Day.";
            notify.NotificationTitle = "CazhOn Days Deal";
            notify.UnreadMsgCount = "7";
            notifications.Add(notify);
            notify.NotificationimageName = "cazhon_giveaway.jpg";
            notify.NotificationimageURL = "https://s3.ap-south-1.amazonaws.com/www.cazhon.com/assets/images/notification/";
            notify.NotificationMessage = "Congrats! You won a giveway. Please contact our Team at contact@cazhon.co";
            notify.NotificationTitle = "CazhOn Giveaway";
            notify.UnreadMsgCount = "7";
            notifications.Add(notify);
            notify.NotificationimageName = "cashback_approved.jpg";
            notify.NotificationimageURL = "https://s3.ap-south-1.amazonaws.com/www.cazhon.com/assets/images/notification/";
            notify.NotificationMessage = "Congrats! You won super cool cashback on the shopping trip you made. Please visit myearnings/shopping tri";
            notify.NotificationTitle = "CazhOn Days Deal";
            notify.UnreadMsgCount = "7";
            notifications.Add(notify);
            await Task.Delay(0);
            NotificationResponse<IEnumerable<Notifications>> response = new NotificationResponse<IEnumerable<Notifications>>();
            response.Data = notifications;
            response.IsSuccess = true;
            return response;

        }


    }
}



