using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Scheduler.Domain.Entities;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Scheduler.Data
{
    public class SchedulerDbContextConfiguration : DbMigrationsConfiguration<SchedulerDbContext>
    {
        public SchedulerDbContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchedulerDbContext context)
        {
            if (!context.Users.Any())
            {
                var userStore = new UserStore<AuthUser>(context);
                var userManager = new UserManager<AuthUser>(userStore);
                var admin = new AuthUser { UserName = "admin", EmailConfirmed = true};
                userManager.Create(admin, "Abc123@");
            }
        }
    }
}
