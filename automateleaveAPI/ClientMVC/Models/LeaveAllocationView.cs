using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientMVC.Models
{
    public class LeaveAllocationView
    {
        public int Employee { get; set; }

        public int Year { get; set; }

        public String Leavetype { get; set; }

        public int Entitledamount { get; set; }

        public int Utilizedamount { get; set; }
    }
}