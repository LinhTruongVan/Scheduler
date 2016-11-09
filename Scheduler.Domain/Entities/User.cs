using System;
using System.Collections.Generic;

namespace Scheduler.Domain.Entities
{
    public class User : IEntityBase
    {
        public User()
        {
            SchedulesCreated = new List<Schedule>();
            SchedulesAttended = new List<Attendee>();
        }
        public long Id { get; set; }
        public Guid AuthUserId { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Profession { get; set; }
        public ICollection<Schedule> SchedulesCreated { get; set; }
        public ICollection<Attendee> SchedulesAttended { get; set; }
    }
}