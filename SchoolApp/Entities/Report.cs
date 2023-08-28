using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Entities
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public int Year { get; set; }
        public int StudentDocument { get; set; }
        public string StudentName { get; set; }
        public string Code { get; set; }
        public string SubjectName { get; set; }
        public int ProfessorDocument { get; set; }
        public string ProfessorName { get; set; }
        public float Grade { get; set; }
        public string Aprobe { get; set; }

    }
}
