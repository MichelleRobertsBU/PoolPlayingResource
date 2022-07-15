using Microsoft.EntityFrameworkCore;
using PoolPlayingResource.Models;

namespace PoolPlayingResource.data
{
    public class Context : DbContext
    {
        public Context() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(@"Data Source=test.db");
        }

        public DbSet<Venue> Venues { get; set; }
    }
}
