using System;
using MacApi1.Models;
using Microsoft.EntityFrameworkCore;
namespace MacApi1.Repo
{
    public class DataContext: DbContext
    {
        public DataContext(): base()
        {
        }
        public DataContext(DbContextOptions<DataContext> options)
                : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MacApi1.Models.Notification> Notification { get; set; }
        //public DbSet<NotificationCountResult> NotificationCountResults { get; set; }
        //public DbSet<NotificationResult> NotificationResults { get; set; }
    }
}
