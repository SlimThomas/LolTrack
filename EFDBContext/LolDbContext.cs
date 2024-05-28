using LolTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace LolTrack.EFDBContext
{
    public class LolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source = mysql24.unoeuro.com; 
                Initial Catalog =LolDb; 
                Integrated security = True; 
                Connect Timeout=30; 
                User ID = mvstm_dk;
                Trust Server Certificate = False; 
                Application Intent = ReadWrite; 
                Multi Subnet Failover = False; 
                Encrypt=False");
        }

        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Rune> Runes { get; set; }
        public DbSet<SSpell> SSpells { get; set; }
        public DbSet<User> Users { get; set; }
        

       


    }
}
