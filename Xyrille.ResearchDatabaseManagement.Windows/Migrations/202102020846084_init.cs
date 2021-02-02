namespace Xyrille.ResearchDatabaseManagement.Windows.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Guid(nullable: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        URL = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Research_Author",
                c => new
                    {
                        ResearchAuthorID = c.Guid(nullable: false),
                        Year = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ResearchAuthorID);
            
            CreateTable(
                "dbo.Researches",
                c => new
                    {
                        ResearchID = c.Guid(nullable: false),
                        Title = c.String(unicode: false),
                        Abstract = c.String(unicode: false),
                        Author = c.String(unicode: false),
                        Leadline = c.String(unicode: false),
                        Year = c.String(unicode: false),
                        IsPublish = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ResearchID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        FullName = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        Lastname = c.String(unicode: false),
                        UserEmail = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Status = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Researches");
            DropTable("dbo.Research_Author");
            DropTable("dbo.Authors");
        }
    }
}
