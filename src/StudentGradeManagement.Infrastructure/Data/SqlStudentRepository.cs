using Microsoft.EntityFrameworkCore;
using StudentGradeManagement.Core.Interfaces;
using StudentGradeManagement.Core.Entities;

namespace StudentGradeManagement.Infrastructure.Data;

public class SqlStudentRepository : IStudentRepository
{
    private readonly SchoolContext _dbContext;

    public SqlStudentRepository(SchoolContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Student> GetByIdAsync(int id)
    {
        return await _dbContext.Students.FindAsync(id);
    }

    public async Task<Student> AddAsync(Student student)
    {
        _dbContext.Students.Add(student);
        await _dbContext.SaveChangesAsync();
        return student;
    }

    public async Task UpdateAsync(Student student)
    {
        _dbContext.Students.Update(student);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var studentToDelete = await _dbContext.Students.FindAsync(id);
        if (studentToDelete != null)
        {
            _dbContext.Students.Remove(studentToDelete);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Student>> GetAllAsync()
    {
        return await _dbContext.Students.ToListAsync();
    }
}