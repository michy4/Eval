namespace Eval.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maj1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mdp = c.String(nullable: false, maxLength: 50),
                        mail = c.String(nullable: false, maxLength: 100),
                        Admin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jeus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Plateforme = c.String(nullable: false, maxLength: 50),
                        DispoEnMagasin = c.Boolean(nullable: false),
                        DispoPourRevendre = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JeuClients",
                c => new
                    {
                        Jeu_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Jeu_Id, t.Client_Id })
                .ForeignKey("dbo.Jeus", t => t.Jeu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Jeu_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JeuClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.JeuClients", "Jeu_Id", "dbo.Jeus");
            DropIndex("dbo.JeuClients", new[] { "Client_Id" });
            DropIndex("dbo.JeuClients", new[] { "Jeu_Id" });
            DropTable("dbo.JeuClients");
            DropTable("dbo.Jeus");
            DropTable("dbo.Clients");
        }
    }
}
