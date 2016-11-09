using Scheduler.Domain.Entities;

namespace Scheduler.Data.Configurations
{
    public class ScheduleConfiguration : EntityBaseConfiguration<Schedule>
    {
        public ScheduleConfiguration()
        {
            HasRequired(x => x.Creator).WithMany(x => x.SchedulesCreated).HasForeignKey(x => x.CreatorId);
        }
    }
}
