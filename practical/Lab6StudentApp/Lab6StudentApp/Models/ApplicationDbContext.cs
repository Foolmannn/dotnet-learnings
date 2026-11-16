using Lab6StudentApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6StudentApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
