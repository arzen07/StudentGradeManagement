using StudentGradeManagement.Application.DTOs;
using StudentGradeManagement.Core.Entities;
using StudentGradeManagement.Core.Interfaces;

namespace StudentGradeManagement.Application.Services;

public class StudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    //Use case - Get a single Student details
    public async Task<StudentDto> GetStudentByIdAsync(int id)
    {
        var student = await _studentRepository.GetByIdAsync(id);
        return student == null
            ? null
            : new StudentDto
            {
                Id = student.Id,
                FullName = student.FullName,
                Email = student.Email,
            };
    }
    
    //Use case - Get all Students
    public async Task<IEnumerable<StudentDto>> GetStudentsAsync()
    {
        var students = await _studentRepository.GetAllAsync();
        return students.Select(student => new StudentDto
        {
            Id = student.Id,
            FullName = student.FullName,
            Email = student.Email,
        }).ToList();
    }
    
    //Use Case - create a new student
    public async Task<StudentDto> CreateStudentAsync(CreateStudentDto createStudentDto)
    {
        var student = new Student
        {
            FirstName = createStudentDto.FirstName,
            LastName = createStudentDto.LastName,
            Email = createStudentDto.Email,
            DateOfBirth = DateTime.SpecifyKind(createStudentDto.DateOfBirth, DateTimeKind.Utc)
        };
        var newStudent = await _studentRepository.AddAsync(student);

        return new StudentDto
        {
            Id = newStudent.Id,
            FullName = newStudent.FullName,
            Email = newStudent.Email,
        };
    }
    
}