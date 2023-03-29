using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Core.Models
{
    public class Notifications
    {
        [JsonProperty(propertyName: "notification_title ")]
        public string NotificationTitle { get; set; }
        [JsonProperty(propertyName: "notification_message ")]
        public string NotificationMessage { get; set; }
        [JsonProperty(propertyName: "notificationimage_url ")]
        public string NotificationimageURL { get; set; }
        [JsonProperty(propertyName: "notificationimage_name")]
        public string NotificationimageName { get; set; }
        [JsonProperty(propertyName: " unread_msg_count ")]
        public string UnreadMsgCount { get; set; }
        [JsonProperty(propertyName: "activated_on")]
        public string ActivatedOn { get; set; }

    }
}
