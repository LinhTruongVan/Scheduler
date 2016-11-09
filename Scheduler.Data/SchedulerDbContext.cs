using Microsoft.AspNet.Identity.EntityFramework;
using Scheduler.Domain.Entities;

namespace Scheduler.Data
{
    public class SchedulerDbContext : IdentityDbContext<AuthUser>
    {
        public SchedulerDbContext()
            : base("name=Scheduler", throwIfV1Schema: false)
        {
        }

        public static SchedulerDbContext Create()
        {
            return new SchedulerDbContext();
        }
    }
}