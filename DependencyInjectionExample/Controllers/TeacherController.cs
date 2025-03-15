using DependencyInjectionExample.Context;
using DependencyInjectionExample.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Teacher
        [HttpGet]
        public IActionResult GetTeachers()
        {
            var teachers = _context.Teachers.ToList();
            return Ok(teachers);
        }

        // ✅ GET: api/Teacher/{id}
        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
                return NotFound("Teacher not found.");

            return Ok(teacher);
        }

        // ✅ POST: api/Teacher
        [HttpPost]
        public IActionResult CreateTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.Id }, teacher);
        }
    }
}
