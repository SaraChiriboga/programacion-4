namespace S3_P4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Edad = c.Int(nullable: false),
                        Carrera = c.String(),
                    })
                .PrimaryKey(t => t.EstudianteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estudiantes");
        }
    }
}
