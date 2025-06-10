using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Core.Interfaces;

public interface IStudentRepository
{
    Task<Student> GetByIdAsync(int id);
    Task<IEnumerable<Student>> GetAllAsync();
    Task<Student> AddAsync(Student student);
    Task UpdateAsync(Student student);
    Task DeleteAsync(int id);
}