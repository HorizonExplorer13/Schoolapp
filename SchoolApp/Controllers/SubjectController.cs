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
        [HttpPost("Create")]
        public async Task<ActionResult> CreateSubject(SubjectDataCreationDTO subject)
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
    }
}
