using Entity_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Entity_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=localhost;Database=EntityTutorial;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true"
            );
        }
    }
}
