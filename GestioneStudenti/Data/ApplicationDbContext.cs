using Microsoft.EntityFrameworkCore;
using GestioneStudenti.Services;

namespace GestioneStudenti.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
