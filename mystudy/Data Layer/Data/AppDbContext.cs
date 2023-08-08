using Data_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace mystudy.Data
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<Student> Students { get; set; }

            public DbSet<Mentor> Mentors { get; set; }

            public DbSet<Course> Courses { get; set; }

            public DbSet<Group> Groups { get; set; }
        }
}