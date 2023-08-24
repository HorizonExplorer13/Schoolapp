using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Entities
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        [ForeignKey("subjects")]
        public int SubjectId { get; set; }
        public Subjects Subjects { get; set; }
        [Required]
        public int Document { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Direction { get; set; }
        [Required]
        public int Phone { get; set; }
    }
}
