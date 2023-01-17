namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Alumnoes");
            AddColumn("dbo.Alumnoes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Alumnoes", "Id");
            DropColumn("dbo.Alumnoes", "AlumnoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumnoes", "AlumnoId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Alumnoes");
            DropColumn("dbo.Alumnoes", "Id");
            AddPrimaryKey("dbo.Alumnoes", "AlumnoId");
        }
    }
}
