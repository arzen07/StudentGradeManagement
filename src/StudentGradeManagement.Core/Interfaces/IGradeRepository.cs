using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Core.Interfaces;

public interface IGradeRepository
{
    Task<Grade> GetByIdAsync(int id);
    Task<IEnumerable<Grade>> GetByStudentIdAsync(int studentId);
    Task<IEnumerable<Grade>> GetByCourseIdAsync(int courseId);
    Task<Grade> AddAsync(Grade grade);
    Task UpdateAsync(Grade grade);
    Task DeleteAsync(int id);
}