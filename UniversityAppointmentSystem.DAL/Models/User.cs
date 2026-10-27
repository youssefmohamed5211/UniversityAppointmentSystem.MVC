using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LasttName { get; set; }
        public string Email { get; set; } = default!;
        public bool IsActive { get; set; } = true;
        public string? Photo { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Student? Student { get; set; }
        public Staff? staff { get; set; }
        public Adminstrator? Adminstrator { get; set; }

        public ICollection<Notification> notifications { get; set; } = new List<Notification>();

        public ICollection<Announcement> announcements { get; set; } = new List<Announcement>();
    }
}
