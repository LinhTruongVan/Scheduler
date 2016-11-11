using System.Data.Entity;

namespace Scheduler.Data
{
    public class SchedulerDbContextInitializer: MigrateDatabaseToLatestVersion<SchedulerDbContext, SchedulerDbContextConfiguration>
    {
    }
}
