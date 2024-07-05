using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):
            base(opt)
        { }
        /* public DbSet<Employee>? Employees => Set<Employee>();
         public DbSet<Library>? Library => Set<Library>();
         public DbSet<Position>? Position => Set<Position>();*/

        public DbSet<Employee> Employees {  get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<Position> Position {  get; set; }

    }
}
