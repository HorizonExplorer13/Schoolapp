using Microsoft.EntityFrameworkCore;
using SchoolApp.Entities;

namespace SchoolApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Professors> professors { get; set; }
        public DbSet<Students> students { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<StudentSubjects> studentSubjects { get; set; }
        public DbSet<Report> reports { get; set; }
    }
}
