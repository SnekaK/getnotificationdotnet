using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cazhon_Notifications.Infrastructure.Context
{
    public class NotificationDbContext : DbContext
    {
        IConfiguration Configuration;
        public NotificationDbContext()
        {

        }
        public NotificationDbContext(DbContextOptions<NotificationDbContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code.
                //You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance
                //on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //  optionsBuilder.UseSqlServer("Data Source=208.91.198.59;Initial Catalog=devcazhondb;Trusted_Connection=False;User ID=devcazhonuser;Password=Cazhon@123;");
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Default"));
            }
        }

    }
}
