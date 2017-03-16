namespace Conference.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        ConferenceId = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 256),
                        Abstract = c.String(nullable: false),
                        StartsAt = c.DateTime(nullable: false),
                        AmountOfLastingDays = c.Int(nullable: false),
                        Lecturer_Email = c.String(nullable: false, maxLength: 256),
                        Location_LocationId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ConferenceId)
                .ForeignKey("dbo.Users", t => t.Lecturer_Email, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.Location_LocationId, cascadeDelete: true)
                .Index(t => t.Title, unique: true, name: "UX_Conference_Title")
                .Index(t => t.Lecturer_Email)
                .Index(t => t.Location_LocationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 256),
                        Name = c.String(nullable: false, maxLength: 512),
                        FirstName = c.String(maxLength: 512),
                        HashedPassword = c.String(nullable: false, maxLength: 342),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Guid(nullable: false),
                        AddressStreet = c.String(nullable: false, maxLength: 128),
                        AddressNumber = c.String(nullable: false, maxLength: 64),
                        AddressPostCode = c.String(nullable: false, maxLength: 16),
                        AddressCity = c.String(nullable: false, maxLength: 128),
                        AddressCountry = c.String(nullable: false, maxLength: 128),
                        AddressCoordinatesLongitude = c.Decimal(nullable: false, precision: 9, scale: 6),
                        AddressCoordinatesLatitude = c.Decimal(nullable: false, precision: 9, scale: 6),
                        RoomName = c.String(nullable: false, maxLength: 128),
                        Floor = c.Int(nullable: false),
                        SquareMetersOfAvailableSpace = c.Decimal(nullable: false, precision: 6, scale: 2),
                        AmountOfAvailableSeats = c.Int(nullable: false),
                        ExpensesPerDay = c.Decimal(nullable: false, precision: 9, scale: 2),
                        CateringCostsPerSeat = c.Decimal(nullable: false, precision: 9, scale: 2),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.ConferenceAttendees",
                c => new
                    {
                        User_Email = c.String(nullable: false, maxLength: 256),
                        Conference_ConferenceId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Email, t.Conference_ConferenceId })
                .ForeignKey("dbo.Users", t => t.User_Email, cascadeDelete: false)
                .ForeignKey("dbo.Conferences", t => t.Conference_ConferenceId, cascadeDelete: false)
                .Index(t => t.User_Email)
                .Index(t => t.Conference_ConferenceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conferences", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.Conferences", "Lecturer_Email", "dbo.Users");
            DropForeignKey("dbo.ConferenceAttendees", "Conference_ConferenceId", "dbo.Conferences");
            DropForeignKey("dbo.ConferenceAttendees", "User_Email", "dbo.Users");
            DropIndex("dbo.ConferenceAttendees", new[] { "Conference_ConferenceId" });
            DropIndex("dbo.ConferenceAttendees", new[] { "User_Email" });
            DropIndex("dbo.Conferences", new[] { "Location_LocationId" });
            DropIndex("dbo.Conferences", new[] { "Lecturer_Email" });
            DropIndex("dbo.Conferences", "UX_Conference_Title");
            DropTable("dbo.ConferenceAttendees");
            DropTable("dbo.Locations");
            DropTable("dbo.Users");
            DropTable("dbo.Conferences");
        }
    }
}
