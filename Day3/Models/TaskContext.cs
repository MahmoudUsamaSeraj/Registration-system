using Microsoft.EntityFrameworkCore;

namespace Day3.Models
{
    public class TaskContext : DbContext
    {

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=OZIL;Database=TaskDB;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True");
        }

    }
}
