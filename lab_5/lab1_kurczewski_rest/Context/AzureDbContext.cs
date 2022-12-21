using Microsoft.EntityFrameworkCore;

namespace lab1_kurczewski_rest {

    public class AzureDbContext : DbContext {
        public AzureDbContext(DbContextOptions<AzureDbContext> options)
        : base(options) {
        }

        public DbSet<Person> People { get; set; }
    }
}