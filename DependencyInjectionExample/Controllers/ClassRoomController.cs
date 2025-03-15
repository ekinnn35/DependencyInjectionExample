using DependencyInjectionExample.Context;
using DependencyInjectionExample.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassRoomController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassRoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/ClassRoom
        [HttpGet]
        public IActionResult GetClassRooms()
        {
            var classRooms = _context.ClassRooms.ToList();
            return Ok(classRooms);
        }

        // ✅ GET: api/ClassRoom/{id}
        [HttpGet("{id}")]
        public IActionResult GetClassRoomById(int id)
        {
            var classRoom = _context.ClassRooms.Find(id);
            if (classRoom == null)
                return NotFound("ClassRoom not found.");

            return Ok(classRoom);
        }

        // ✅ POST: api/ClassRoom
        [HttpPost]
        public IActionResult CreateClassRoom(ClassRoom classRoom)
        {
            _context.ClassRooms.Add(classRoom);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetClassRoomById), new { id = classRoom.Id }, classRoom);
        }
    }
}
