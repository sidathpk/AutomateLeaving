using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace automateleaveAPI.Models
{
    public class LeaveType
    {
        [Key]
        public int Leavetypecode { get; set; }

        public String Description { get; set; }
    }
}