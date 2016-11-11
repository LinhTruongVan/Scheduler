namespace Scheduler.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SchedulerDbContext _dbContext;

        public SchedulerDbContext Init()
        {
            return _dbContext ?? (_dbContext = new SchedulerDbContext());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}
