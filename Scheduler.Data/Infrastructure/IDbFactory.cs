using System;

namespace Scheduler.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SchedulerDbContext Init();
    }
}
