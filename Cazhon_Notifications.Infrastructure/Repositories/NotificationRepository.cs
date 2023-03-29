using AutoMapper;
using Cazhon_Notifications.Core.Interfaces.Repositories;
using Cazhon_Notifications.Core.Models;
using Cazhon_Notifications.Core.Response;
using Cazhon_Notifications.Infrastructure.Context;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Infrastructure.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly NotificationDbContext _dBContext;
        private readonly IMapper _mapper;
        protected IConfiguration configuration;
        public NotificationRepository(NotificationDbContext dBContext, IMapper mapper, IConfiguration configuration)
        {
            _dBContext = dBContext ?? throw new ArgumentNullException(nameof(dBContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public SqlConnection GetSqlConnection()
        {
            var connectionString = configuration.GetConnectionString("Default");
            return new SqlConnection(connectionString);
        }

        public async Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification()
        {
            NotificationResponse<IEnumerable<Notifications>> response = new NotificationResponse<IEnumerable<Notifications>>();
            List<Notifications> notifications = new List<Notifications>();
            Notifications notify = null;
            try
            {

                using (SqlConnection conn = GetSqlConnection())
                {
                    try
                    {
                        conn.Open();
                        var command = new SqlCommand("exec[dbo].[ sp_get_user_notification]", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            notify = new Notifications();
                            notify.NotificationTitle = reader["notification_title"].ToString();
                            notify.NotificationMessage = reader["notification_message"].ToString();
                            notify.NotificationimageName = reader["notificationimage_name"].ToString();
                            notify.NotificationimageURL = reader["notificationimage_url"].ToString();
                            notify.UnreadMsgCount = reader["unread_msg_count"].ToString();
                            notify.ActivatedOn = reader["activated_on"].ToString();

                            notifications.Add(notify);
                        }
                        response.Data = notifications;
                        response.IsSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQL Error: " + ex.Message);
                        response.Message = ex.Message;
                        response.IsSuccess = false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

                await Task.Delay(10);

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }

        public async Task<NotificationResponse<IEnumerable<Notifications>>> GetNotification(string id)
        {
            NotificationResponse<IEnumerable<Notifications>> response = new NotificationResponse<IEnumerable<Notifications>>();
            List<Notifications> notifications = new List<Notifications>();
            Notifications notify = null;
            try
            {

                using (SqlConnection conn = GetSqlConnection())
                {
                    try
                    {
                        conn.Open();
                        var command = new SqlCommand("exec[dbo].[sp_get_user_notification @user_guid ]", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            notify = new Notifications();
                            notify.NotificationTitle = reader["notification_title"].ToString();
                            notify.NotificationMessage = reader["notification_message"].ToString();
                            notify.NotificationimageName = reader["notificationimage_name"].ToString();
                            notify.NotificationimageURL = reader["notificationimage_url"].ToString();
                            notify.UnreadMsgCount = reader["unread_msg_count"].ToString();
                            notify.ActivatedOn = reader["activated_on"].ToString();

                            notifications.Add(notify);
                        }
                        response.Data = notifications;
                        response.IsSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQL Error: " + ex.Message);
                        response.Message = ex.Message;
                        response.IsSuccess = false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

                await Task.Delay(10);

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }



    }
}
