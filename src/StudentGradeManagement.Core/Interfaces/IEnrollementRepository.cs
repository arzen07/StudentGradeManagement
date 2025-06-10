using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Core.Interfaces;

public interface IEnrollementRepository
{
    Task<Enrollment> GetByIdAsync(int id);
    Task<IEnumerable<Enrollment>> GetByStudentIdAsync(int studentId);
    Task<IEnumerable<Enrollment>> GetByCourseIdAsync(int courseId);
    Task<Enrollment> AddAsync(Enrollment enrollment);
    Task UpdateAsync(Enrollment enrollment);
    Task DeleteAsync(int id);
}