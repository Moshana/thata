namespace Sample2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeSurname = c.String(),
                        EmployeePhone = c.String(),
                        EmployeeAddress = c.String(),
                        EmployeeEmail = c.String(),
                        UserName = c.String(),
                        EmployeePassword = c.String(),
                        AccessLevel = c.String(),
                        EmployeeTypeID_EmployeeTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.EmployeeTypes", t => t.EmployeeTypeID_EmployeeTypeID)
                .Index(t => t.EmployeeTypeID_EmployeeTypeID);
            
            CreateTable(
                "dbo.EmployeeTypes",
                c => new
                    {
                        EmployeeTypeID = c.Int(nullable: false, identity: true),
                        EmployeeDescription = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EmployeeTypeID_EmployeeTypeID", "dbo.EmployeeTypes");
            DropIndex("dbo.Employees", new[] { "EmployeeTypeID_EmployeeTypeID" });
            DropTable("dbo.EmployeeTypes");
            DropTable("dbo.Employees");
        }
    }
}
