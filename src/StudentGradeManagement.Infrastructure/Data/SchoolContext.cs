using Microsoft.EntityFrameworkCore;
using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Infrastructure.Data;

public class SchoolContext :DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //One grade per course
        modelBuilder.Entity<Grade>()
            .HasIndex(g => new {g.StudentId, g.CourseId})
            .IsUnique();
    }
}
