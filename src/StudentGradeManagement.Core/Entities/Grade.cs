namespace StudentGradeManagement.Core.Entities;

public class Grade
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string LetterGrade { get; set; }
    public decimal NumericValue { get; set; }
    public DateTime DateAssigned { get; set; }
    public string Comments { get; set; }
    
    //Navigation Properties
    public Student Student { get; set; }
    public Course Course {get; set; }
    
    //Helper method to convert letter grade to numeric grade
    public static decimal GetNumericValue(string LetterGrade)
    {
        return LetterGrade?.ToUpper() switch
        {
            "A" => 4.0m,
            "B" => 3.0m,
            "C" => 2.0m,
            "D" => 1.0m,
            "F" => 0.0m,
            _ => 0.0m,
        };
    }
}