using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.DTO;
using SchoolApp.Entities;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("api/Students")]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public StudentController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("Getlist")]
        public async Task<IActionResult> Getlist()
        {
            var Studentlist = await dbContext.students.ToListAsync();
            if (Studentlist == null)
            {
                return NotFound();
            }
            return Ok(Studentlist);
        }
        [HttpGet("GetById/{studentId}")]
        public async Task<IActionResult> GetById(int studentId)
        {
            var student = await dbContext.students.FirstOrDefaultAsync(x => x.StudentId == studentId);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateStundent([FromBody] StudentDataCreation student)
        {
            var newstudent = new Students
            {
                Document = student.Document,
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age,
                Direction = student.Direction,
                Phone = student.Phone,
            };

            dbContext.students.Add(newstudent);
            var result = await dbContext.SaveChangesAsync();
            if (result == 0)
            {
                return BadRequest(result);
            }
            return Ok(newstudent);
        }
        [HttpPut]
        [HttpDelete("Delete/{studentId}")]
        public async Task<IActionResult> Deletestudent(int studentId)
        {
            return Ok();
        }
    }
}
