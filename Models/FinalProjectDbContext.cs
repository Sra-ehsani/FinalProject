
using Microsoft.EntityFrameworkCore;
using Models.DomainModels;

namespace Models
{
    public class FinalProjectDbContext: DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = FinalProjectDb; Integrated Security = True; Trust Server Certificate = True;");
        }
    }
}

