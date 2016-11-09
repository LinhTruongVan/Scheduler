namespace Scheduler.Domain.Entities
{
    public class Attendee : IEntityBase
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }

        public long ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}