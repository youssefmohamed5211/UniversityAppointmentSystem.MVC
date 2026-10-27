using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAppointmentSystem.DAL.Models.Enums
{
    public enum Requirment_status
    {
        Pending = 1,      
        Submitted = 2,        
        LateSubmitted = 3,   
        UnderReview = 4,      
        Accepted = 5,        
        Rejected = 6,         
        Missed = 7
    }
}
