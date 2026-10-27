using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models
{
    public class Department
    {

        public int Id { get; set; }

        public string DeptName { get; set; } = default!;

        public string Code { get; set; } =default!;

        public string Description { get; set; } = default!;
    }
}
