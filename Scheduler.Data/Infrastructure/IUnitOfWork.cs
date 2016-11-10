namespace Scheduler.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
