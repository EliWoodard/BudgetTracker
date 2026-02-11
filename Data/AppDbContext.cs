using BudgetTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts => Set<Account>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = Path.Combine(
                FileSystem.AppDataDirectory,
                "budget.db");

            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
