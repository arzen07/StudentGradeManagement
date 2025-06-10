namespace StudentGradeManagement.Core.Entities;

public class Course
{
    public int Id { get; set; }
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int CreditHours { get; set; }
    public int TeacherId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    //Navigation Properties
    public Teacher Teacher { get; set; }
    
    
}