using Microsoft.EntityFrameworkCore;
using GestioneStudenti.Services;

namespace GestioneStudenti.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=StudentTest;");
        }


    }
}
