using System.Data.Entity.Migrations;

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

        }
    }
}
