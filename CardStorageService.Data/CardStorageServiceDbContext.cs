using Microsoft.EntityFrameworkCore;

namespace CardStorageService.Data
{
    public class CardStorageServiceDbContext : DbContext
    {

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Card> Cards { get; set; }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountSession> AccountSessions { get; set; }

        public CardStorageServiceDbContext(DbContextOptions options) : base(options) { }
    }
}
