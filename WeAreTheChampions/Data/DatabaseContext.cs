using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Models;

namespace WeAreTheChampions.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DatabaseContext")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<TeamColor> TeamColors { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
