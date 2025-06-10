namespace StudentGradeManagement.Core.Entities;

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
    public EnrollmentStatus Status { get; set; } = EnrollmentStatus.Active;
    
    //navigation properties
    public Course Course { get; set; }
    public Student Student { get; set; }
    
    //Enrollment Status Enum
    public enum EnrollmentStatus
    {
        Active = 1,
        Inactive = 2,
        Dropped = 3,
        Withdrawn = 4
    }
}