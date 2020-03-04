using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Entities
{
    public class CampusContext : DbContext
    {
        public CampusContext(DbContextOptions<CampusContext> options):base(options)
        {
            Database.Migrate();
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<SubEvents> SubEvents { get; set; }
        public DbSet<Participent> Participents { get; set; }
    }
}
