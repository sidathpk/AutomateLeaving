using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace automateleaveAPI.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("DefaultConnection")
        {

        }

        public DbSet<EmpMasterFile> EmpMasterFiles { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<LeaveEntry> LeaveEntrys { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}