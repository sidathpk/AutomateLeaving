using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace automateleaveAPI.Models
{
    public class LeaveAllocation
    {
        [Key]
        public int Employee { get; set; }

        public int Year { get; set; }

        public String Leavetype { get; set; }

        public int Entitledamount { get; set; }

        public int Utilizedamount { get; set; }
    }
}