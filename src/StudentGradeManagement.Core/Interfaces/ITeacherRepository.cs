using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Core.Interfaces;

public interface ITeacherRepository
{
    Task<Teacher> GetByIdAsync(int id);
    Task<IEnumerable<Teacher>> GetAllAsync();
    Task<Teacher> AddAsync(Teacher teacher);
    Task UpdateAsync(Teacher teacher);
    Task DeleteAsync(int id);
}