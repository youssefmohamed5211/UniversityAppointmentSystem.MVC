using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Courses
    {
        public int id { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string Credit_hours { get; set;}
        public string Level { get; set;}
        public int Max_Capacity { get; set; }
        public Boolean Is_Active { get; set; } = true;
    }
}
