using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> CourseList { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
    }
}
