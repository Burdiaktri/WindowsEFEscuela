namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionAlumnoProfesor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnoes", "ProfesorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumnoes", "ProfesorId");
            AddForeignKey("dbo.Alumnoes", "ProfesorId", "dbo.Docente", "ProfesorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnoes", "ProfesorId", "dbo.Docente");
            DropIndex("dbo.Alumnoes", new[] { "ProfesorId" });
            DropColumn("dbo.Alumnoes", "ProfesorId");
        }
    }
}
