using System;
using System.Collections.Generic;

namespace Scheduler.Domain.Entities
{
    public class Schedule : IEntityBase
    {
        public Schedule()
        {
            Attendees = new List<Attendee>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Location { get; set; }
        public ScheduleType Type { get; set; }

        public ScheduleStatus Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public User Creator { get; set; }
        public int CreatorId { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
    }

    public enum ScheduleType
    {
        Work = 1,
        Coffee = 2,
        Doctor = 3,
        Shopping = 4,
        Other = 5
    }

    public enum ScheduleStatus
    {
        Valid = 1,
        Cancelled = 2
    }
}
