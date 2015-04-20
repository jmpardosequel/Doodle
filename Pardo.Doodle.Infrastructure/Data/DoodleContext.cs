using System.Data.Entity;
using Pardo.Doodle.Core.Model;

namespace Pardo.Doodle.Infrastructure.Data
{
    public class DoodleContext : DbContext
    {
        protected DoodleContext(): base("name=DoodleContext")
        {
        }

        public DbSet<Meeting> Events { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<DatePropossal> DatePropossal { get; set; }

    }
}