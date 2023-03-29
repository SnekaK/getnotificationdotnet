using AutoMapper;
using Cazhon_Notifications.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Infrastructure.Mapper
{
    public class NotificationMapper : Profile
    {


        public NotificationMapper()
        {
            CreateMap<Cazhon_Notifications.Core.Models.Notifications, Notifications>()
            .ReverseMap();
        }
    }
}
