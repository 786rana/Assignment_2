using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Assignment_2.Data.Assignment2
{
    
    public class Assignment2DbContext : DbContext
    {
        public Assignment2DbContext(DbContextOptions<Assignment2DbContext> options) : base(options)
        { }
        public DbSet<Class> Class { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Facultys { get; set; }
        public DbSet<Enrolled> Enrolleds { get; set; }
    }
}
