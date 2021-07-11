namespace DBGemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ShipID = c.Int(nullable: false, identity: true),
                        ShipName = c.String(),
                        Country = c.String(),
                        ContactInfo = c.String(),
                        Tel = c.String(),
                    })
                .PrimaryKey(t => t.ShipID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ships");
        }
    }
}
