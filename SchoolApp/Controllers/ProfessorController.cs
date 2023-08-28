using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.DTO;
using SchoolApp.Entities;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("api/professors")]
    public class ProfessorController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public ProfessorController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("Getlist")]
        public async Task<IActionResult> Getlist()
        {
            var Studentlist = await dbContext.professors.ToListAsync();
            if (Studentlist == null)
            {
                return NotFound();
            }
            return Ok(Studentlist);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateStundent([FromBody] ProfessorDataCreationDTO professor)
        {
            var newproffesor = new Professors
            {
                SubjectId = professor.SubjectId,
                Document = professor.Document,
                Name = professor.Name,
                Surname = professor.Surname,
                Age = professor.Age,
                Direction = professor.Direction,
                Phone = professor.Phone,
            };

            dbContext.professors.Add(newproffesor);
            var result = await dbContext.SaveChangesAsync();
            if (result == 0)
            {
                return BadRequest(result);
            }
            return Ok(newproffesor);
        }
    }
}
