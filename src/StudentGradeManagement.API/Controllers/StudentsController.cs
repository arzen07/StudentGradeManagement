using Microsoft.AspNetCore.Mvc;
using StudentGradeManagement.Application.DTOs;
using StudentGradeManagement.Application.Services;


namespace StudentGradeManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentsController(StudentService studentService)
    {
        _studentService = studentService;
    }

    //Get all students
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDto>>> GetAllStudents()
    {
        var students = await _studentService.GetStudentsAsync();
        return Ok(students);
    }
    
    //Get Single Student by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDto>> GetStudentById(int id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        
        return student == null ? NotFound() : Ok(student);
    }
    
    //Create a new student
    [HttpPost]
    public async Task<ActionResult<StudentDto>> CreateStudent(CreateStudentDto createStudentDto)
    {
        var newStudent = await _studentService.CreateStudentAsync(createStudentDto);
        return CreatedAtAction(nameof(GetStudentById), new { id = newStudent.Id }, newStudent);
    }
}
    