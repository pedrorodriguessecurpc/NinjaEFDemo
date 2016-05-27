using System.Data.Entity;

namespace Konoha.DataModel
{
    public class KonohaContext : DbContext
    {
        public DbSet<Shinobi> Shinobis { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Justu> Justus { get; set; }
    }
}