using hogwarts_repository.Models;
using Microsoft.EntityFrameworkCore;

namespace hogwarts_repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<House> Houses { get; set; }
    }
}