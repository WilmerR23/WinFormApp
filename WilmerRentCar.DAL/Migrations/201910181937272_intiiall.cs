namespace WilmerRentCar.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiiall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TarjetaCredito = c.String(),
                        LimiteCredito = c.Int(nullable: false),
                        PersonaId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cedula = c.String(),
                        TipoPersonaId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoPersonas", t => t.TipoPersonaId, cascadeDelete: true)
                .Index(t => t.TipoPersonaId);
            
            CreateTable(
                "dbo.TipoPersonas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TandaLabor = c.String(),
                        PorCientoComision = c.String(),
                        FechaIngreso = c.DateTime(nullable: false),
                        PersonaId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Inspección",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehiculoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                        CantidadCombustible = c.String(),
                        FechaInspeccion = c.DateTime(nullable: false),
                        Ralladuras = c.Boolean(nullable: false),
                        GomaRepuesta = c.Boolean(nullable: false),
                        Gato = c.Boolean(nullable: false),
                        RoturaCristal = c.Boolean(nullable: false),
                        Goma1 = c.Boolean(nullable: false),
                        Goma2 = c.Boolean(nullable: false),
                        Goma3 = c.Boolean(nullable: false),
                        Goma4 = c.Boolean(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoId, cascadeDelete: false)
                .ForeignKey("dbo.Vehículo", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.VehiculoId)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Vehículo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Chasis = c.String(),
                        Motor = c.String(),
                        Placa = c.String(),
                        TipoVehiculoId = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        TipoCombustibleId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .ForeignKey("dbo.Modeloes", t => t.ModeloId, cascadeDelete: true)
                .ForeignKey("dbo.TipoCombustibles", t => t.TipoCombustibleId, cascadeDelete: true)
                .ForeignKey("dbo.TipoVehiculoes", t => t.TipoVehiculoId, cascadeDelete: true)
                .Index(t => t.TipoVehiculoId)
                .Index(t => t.MarcaId)
                .Index(t => t.ModeloId)
                .Index(t => t.TipoCombustibleId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: false)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.TipoCombustibles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoVehiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentaDevolucions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Renta = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                        FechaRenta = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        MontoDia = c.Int(nullable: false),
                        Dias = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoId, cascadeDelete: false)
                .ForeignKey("dbo.Vehículo", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.VehiculoId)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Clave = c.String(),
                        EmpleadoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoId, cascadeDelete: true)
                .Index(t => t.EmpleadoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.RentaDevolucions", "VehiculoId", "dbo.Vehículo");
            DropForeignKey("dbo.RentaDevolucions", "EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.RentaDevolucions", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Inspección", "VehiculoId", "dbo.Vehículo");
            DropForeignKey("dbo.Vehículo", "TipoVehiculoId", "dbo.TipoVehiculoes");
            DropForeignKey("dbo.Vehículo", "TipoCombustibleId", "dbo.TipoCombustibles");
            DropForeignKey("dbo.Vehículo", "ModeloId", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Vehículo", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Inspección", "EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.Inspección", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Empleadoes", "PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Clientes", "PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Personas", "TipoPersonaId", "dbo.TipoPersonas");
            DropIndex("dbo.Usuarios", new[] { "EmpleadoId" });
            DropIndex("dbo.RentaDevolucions", new[] { "EmpleadoId" });
            DropIndex("dbo.RentaDevolucions", new[] { "ClienteId" });
            DropIndex("dbo.RentaDevolucions", new[] { "VehiculoId" });
            DropIndex("dbo.Modeloes", new[] { "MarcaId" });
            DropIndex("dbo.Vehículo", new[] { "TipoCombustibleId" });
            DropIndex("dbo.Vehículo", new[] { "ModeloId" });
            DropIndex("dbo.Vehículo", new[] { "MarcaId" });
            DropIndex("dbo.Vehículo", new[] { "TipoVehiculoId" });
            DropIndex("dbo.Inspección", new[] { "EmpleadoId" });
            DropIndex("dbo.Inspección", new[] { "ClienteId" });
            DropIndex("dbo.Inspección", new[] { "VehiculoId" });
            DropIndex("dbo.Empleadoes", new[] { "PersonaId" });
            DropIndex("dbo.Personas", new[] { "TipoPersonaId" });
            DropIndex("dbo.Clientes", new[] { "PersonaId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.RentaDevolucions");
            DropTable("dbo.TipoVehiculoes");
            DropTable("dbo.TipoCombustibles");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Vehículo");
            DropTable("dbo.Inspección");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.TipoPersonas");
            DropTable("dbo.Personas");
            DropTable("dbo.Clientes");
        }
    }
}
