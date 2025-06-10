namespace StudentGradeManagement.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string FullName => $"{FirstName} {LastName}";
        
        //Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        public decimal CalulateGPA()
        {
            if (!Grades.Any()) return 0.0m;
            return Math.Round(Grades.Average(g => g.NumericValue), 2);
        }
        
    }
}