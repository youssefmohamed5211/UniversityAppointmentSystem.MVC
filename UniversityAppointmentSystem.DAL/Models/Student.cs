using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Student
    {
        public string Nationality { get; set; }

        public decimal GPA { get; set; }

        public string AcademicLevel { get; set; } // مثل: الفرقة الأولى، مستوى ثالث، إلخ

        public int Age { get; set; }

        public User User { get; set; } = default!;

        [Key, ForeignKey("User")] 
        public int Id { get; set; }

    }
}
