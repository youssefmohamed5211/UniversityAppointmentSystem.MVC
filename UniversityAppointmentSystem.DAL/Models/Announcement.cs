using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;

        public string Content { get; set; } = default!; 

        public DateTime? PublishedAt { get; set; } 
        public DateTime? ExpiredAt { get; set; }   

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public User publisher { get; set; }
        public int PublisherId { get; set; }
    }
}
