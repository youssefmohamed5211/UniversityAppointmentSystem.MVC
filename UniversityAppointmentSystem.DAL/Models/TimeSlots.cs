using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class TimeSlots
    {
        public int Id { get; set; }

        public DayOfWeek Day { get; set; }

        public TimeSpan StartTime { get; set; } 

        public TimeSpan EndTime { get; set; }  

        public bool IsActive { get; set; } = true;

        public int MaxCapacity { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
