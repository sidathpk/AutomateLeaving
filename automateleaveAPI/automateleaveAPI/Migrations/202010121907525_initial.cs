namespace automateleaveAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpMasterFiles",
                c => new
                    {
                        EmpCode = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        SupervisorCode = c.String(),
                        LeaveType = c.String(),
                    })
                .PrimaryKey(t => t.EmpCode);
            
            CreateTable(
                "dbo.LeaveAllocations",
                c => new
                    {
                        Employee = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Leavetype = c.String(),
                        Entitledamount = c.Int(nullable: false),
                        Utilizedamount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Employee);
            
            CreateTable(
                "dbo.LeaveEntries",
                c => new
                    {
                        Employeecode = c.Int(nullable: false, identity: true),
                        LeaveType = c.String(),
                        RequestedDate = c.DateTime(nullable: false),
                        ActionTakenDate = c.DateTime(nullable: false),
                        ActionTakenBy = c.Int(nullable: false),
                        Status = c.String(),
                        EmployeeComment = c.String(),
                        SupervisorComment = c.String(),
                        AuoNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Employeecode);
            
            CreateTable(
                "dbo.LeaveTypes",
                c => new
                    {
                        Leavetypecode = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Leavetypecode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveTypes");
            DropTable("dbo.LeaveEntries");
            DropTable("dbo.LeaveAllocations");
            DropTable("dbo.EmpMasterFiles");
        }
    }
}
