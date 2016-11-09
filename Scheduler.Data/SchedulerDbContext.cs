using Microsoft.AspNet.Identity.EntityFramework;
using Scheduler.Data.Configurations;
using Scheduler.Domain.Entities;
using System.Data.Entity;

namespace Scheduler.Data
{
    public class SchedulerDbContext : IdentityDbContext<AuthUser>
    {
        public SchedulerDbContext()
            : base("name=Scheduler", throwIfV1Schema: false)
        {
            Database.SetInitializer(new SchedulerDbContextInitializer());
        }

        public static SchedulerDbContext Create()
        {
            return new SchedulerDbContext();
        }

        #region Entity Sets
        public IDbSet<User> UserSet { get; set; }
        public IDbSet<Schedule> ScheduleSet { get; set; }
        public IDbSet<Attendee> AttendeeSet { get; set; }
        #endregion

        public virtual void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ScheduleConfiguration());
            modelBuilder.Configurations.Add(new AttendeeConfiguration());
        }
    }
}