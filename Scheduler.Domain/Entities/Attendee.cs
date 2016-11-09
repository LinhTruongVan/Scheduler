namespace Scheduler.Domain.Entities
{
    public class Attendee : IEntityBase
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}