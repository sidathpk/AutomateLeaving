using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace automateleaveAPI.Models
{
    public class EmpMasterFile
    {
        [Key]
        public int EmpCode { get; set; }

        public String EmpName { get; set; }

        public String SupervisorCode { get; set; }

        public String LeaveType { get; set; }


    }
}