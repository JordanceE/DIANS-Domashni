namespace ВиноХармони.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatingwineriesdatatable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wineries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        PhoneNumber = c.String(),
                        InternationalPhoneNumber = c.String(),
                        OpeningHours = c.String(),
                        Website = c.String(),
                        Rating = c.Single(nullable: false),
                        TotalReviews = c.Int(nullable: false),
                        GoogleMapsURL = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wineries");
        }
    }
}
