using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAppointmentSystem.DAL.Models.Enums;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class StudentSubmission
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = default!;     

        public DateTime? SubmissionDate { get; set; }          // وقت ما الطالب داس "تسليم"
        public string? FilePath { get; set; }                  // اللينك أو الفايل (PDF / Zip)

        public Requirment_status Status { get; set; }

        public decimal? Grade { get; set; }                   
        public string? Feedback { get; set; }

        //fk with requirments  and student 
    }
}
