namespace TestDateBase.DB
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {

        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(maxLength: 2147483647),
                    people_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.people_Id)
                .Index(t => t.people_Id);

            CreateTable(
                "dbo.People",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 2147483647),
                    Age = c.Int(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Books", "people_Id", "dbo.People");
            DropIndex("dbo.Books", new[] { "people_Id" });
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }

}
