using LolTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace LolTrack.EFDBContext
{
    public class LolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=mssql11.unoeuro.com;Initial Catalog=mvstm_dk_db_loldata;User ID=mvstm_dk;Password=btpykdac5GHBrm4fFg6A;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False") ;
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
