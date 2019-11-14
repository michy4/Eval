namespace Eval.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maj3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        client_Id = c.Int(nullable: false),
                        jeu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Jeus", t => t.jeu_Id, cascadeDelete: true)
                .Index(t => t.client_Id)
                .Index(t => t.jeu_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "jeu_Id", "dbo.Jeus");
            DropForeignKey("dbo.Reservations", "client_Id", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "jeu_Id" });
            DropIndex("dbo.Reservations", new[] { "client_Id" });
            DropTable("dbo.Reservations");
        }
    }
}
