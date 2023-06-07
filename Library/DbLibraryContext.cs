using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library;

public class BankContext : DbContext {

    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseInMemoryDatabase (databaseName: "BankSystem");
        }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<BalanceAccount> BalanceAccounts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<BalanceAccount> TransactionTypes { get; set; }
}