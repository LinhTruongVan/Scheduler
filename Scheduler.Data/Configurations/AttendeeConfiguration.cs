using Scheduler.Domain.Entities;

namespace Scheduler.Data.Configurations
{
    public class AttendeeConfiguration : EntityBaseConfiguration<Attendee>
    {
        public AttendeeConfiguration()
        {
            HasRequired(x => x.User).WithMany(x => x.SchedulesAttended).HasForeignKey(x => x.UserId);
            HasRequired(x => x.Schedule).WithMany(x => x.Attendees).HasForeignKey(x => x.ScheduleId);
        }
    }
}
