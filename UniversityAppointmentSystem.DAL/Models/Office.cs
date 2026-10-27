using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Office
    {
        public int Id { get; set; }


        public string Name { get; set; } = default!;

        public string Location { get; set; } = default!;

        public int Capacity { get; set; } 


        public string Description { get; set; } = default!;

        public bool IsActive { get; set; } = true;
    }
}
