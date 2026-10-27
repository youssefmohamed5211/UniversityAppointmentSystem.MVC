using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class FeedBack
    {
        public int Id { get; set; }

        [Range(1, 5, ErrorMessage = "Rating Should Be in range from 1 to 5")]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string? Comments { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
