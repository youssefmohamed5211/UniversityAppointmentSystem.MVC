using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Notification
    {
        public int Id { get; set; }

        public string Title { get; set; } = default!; 

        public string Message { get; set; } = default!; 

        public bool IsRead { get; set; } = false; 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public User user { get; set; }

        public int UserId { get; set; }//Fk
    }
}
