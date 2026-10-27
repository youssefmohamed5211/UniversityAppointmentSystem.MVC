using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UniversityAppointmentSystem.DAL.Models.Enums;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Requirments
    {
        public int Id { get; set; }
        public String Title { get; set; } = default!;
        public String Description { get; set; } = default!;
        public DateTime DueDate { get; set; }
        //fk with meeting
    }
}
