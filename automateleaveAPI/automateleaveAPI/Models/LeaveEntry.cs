using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace automateleaveAPI.Models
{
    public class LeaveEntry
    {
        [Key]
        public int Employeecode { get; set; }

        public String LeaveType { get; set; }

        public DateTime RequestedDate { get; set; }

        public DateTime ActionTakenDate { get; set; }

        public int ActionTakenBy { get; set; }

        public String Status { get; set; }

        public String EmployeeComment { get; set; }

        public String SupervisorComment { get; set; }

        public int AuoNumber { get; set; }
    }
}