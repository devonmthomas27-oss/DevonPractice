using DevonPracticeInfrastructure.Widgets;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevonPracticeInfrastructure
{
    public sealed class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions options)
            :base(options)
        {
            Database.EnsureCreated();


            Widgets = Set<Widget>();
        }


        public DbSet<Widget>  Widgets { get; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
