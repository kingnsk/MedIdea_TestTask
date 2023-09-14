namespace ClinicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertDateTimeToDatetime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientCards", "DateOfBirth", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientCards", "DateOfBirth", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
