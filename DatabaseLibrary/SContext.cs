using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SportiskasVilnius.DatabaseLibrary;

namespace DatabaseLibrary
{
    public class SContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; } 
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public SContext()
        {
            
        }
    }
}
