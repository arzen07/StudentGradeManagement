using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Core.Interfaces;

public interface ICourseRepository
{
    Task<Course> GetByIdAsync(int id);
    Task<IEnumerable<Course>> GetAllAsync();
    Task<Course> AddAsync(Course course);
    Task UpdateAsync(Course course);
    Task DeleteAsync(Course course);
}