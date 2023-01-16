namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Alumnoes", name: "Nombre", newName: "Alumno");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Alumnoes", name: "Alumno", newName: "Nombre");
        }
    }
}
