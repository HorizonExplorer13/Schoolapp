using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.DTO;
using SchoolApp.Entities;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("api/Subjects")]
    public class SubjectController :ControllerBase
    {
        private readonly AppDbContext dbContext;

        public SubjectController(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        [HttpGet("Getlist")]
        public async Task<IActionResult> Getlist()
        {
            var Subjectlist = await dbContext.subjects.ToListAsync();
            if (Subjectlist != null)
            {
                return Ok(Subjectlist);
            }
            return BadRequest();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateSubject([FromBody] SubjectDataCreationDTO subject)
        {
            var Subjectdata = new Subjects
            {
                Code = subject.Code,
                Name = subject.Name,
            };
            dbContext.subjects.Add(Subjectdata);
            var result = await dbContext.SaveChangesAsync();
            if(result is 0)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateSubject()
        {
            return Ok();
        }
    }
}
