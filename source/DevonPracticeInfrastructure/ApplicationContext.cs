using Microsoft.EntityFrameworkCore;

namespace DevonPracticeInfrastructure
{
    public sealed class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
