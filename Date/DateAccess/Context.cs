using Date.Models;
using Microsoft.EntityFrameworkCore;

namespace Date.DateAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=Date;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
    }
}
