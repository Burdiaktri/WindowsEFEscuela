namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Profesors", newName: "Docente");
            AddColumn("dbo.Docente", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnoes", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnoes", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Docente", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Docente", "Apellido", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Docente", "Apellido", c => c.String());
            AlterColumn("dbo.Docente", "Nombre", c => c.String());
            AlterColumn("dbo.Alumnoes", "Apellido", c => c.String());
            AlterColumn("dbo.Alumnoes", "Nombre", c => c.String());
            DropColumn("dbo.Docente", "Titulo");
            RenameTable(name: "dbo.Docente", newName: "Profesors");
        }
    }
}
