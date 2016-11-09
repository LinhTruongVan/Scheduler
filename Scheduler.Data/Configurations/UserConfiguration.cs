using Scheduler.Domain.Entities;

namespace Scheduler.Data.Configurations
{
    public class UserConfiguration : EntityBaseConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.Name).HasMaxLength(100).IsRequired();
        }
    }
}
