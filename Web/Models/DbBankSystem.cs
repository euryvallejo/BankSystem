using Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Models;

public class BankContext : IdentityDbContext<User>
{

    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseInMemoryDatabase (databaseName: "BankSystem");
        }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<BalanceAccount> BalanceAccounts { get; set; }
    public DbSet<User> Customers { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<BalanceAccount> TransactionTypes { get; set; }
}