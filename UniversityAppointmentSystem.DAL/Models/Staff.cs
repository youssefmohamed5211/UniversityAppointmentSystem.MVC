using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAppointmentSystem.DAL.Models.Enums;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Staff
    {
        public StaffRole Role { get; set; } // مثل: Doctor, TA, Professor, Administrator,Director
        public string Phone { get; set; } = default!;


        public int DepartmentId { get; set; }

        public bool IsActive { get; set; } = true;


        public string OfficeNumber { get; set; } = default!;


        public string Bio { get; set; } = default!;
        public DateTime HiredDate { get; set; } = DateTime.Now;
        public User user { get; set; } = default!;

        [Key, ForeignKey("User")] 
        public int Id { get; set; }
    }
}
