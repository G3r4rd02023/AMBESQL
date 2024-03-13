using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoAMBE.Data;

public partial class AmbedbContext : DbContext
{
    public AmbedbContext()
    {
    }

    public AmbedbContext(DbContextOptions<AmbedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bitacora> Bitacora { get; set; }

    public virtual DbSet<Contactos> Contactos { get; set; }

    public virtual DbSet<Grados> Grados { get; set; }

    public virtual DbSet<Incidentes> Incidentes { get; set; }

    public virtual DbSet<InstitutoRoles> InstitutoRoles { get; set; }

    public virtual DbSet<InstitutoUsuarios> InstitutoUsuarios { get; set; }

    public virtual DbSet<Institutos> Institutos { get; set; }

    public virtual DbSet<Marcas> Marcas { get; set; }

    public virtual DbSet<Modelos> Modelos { get; set; }

    public virtual DbSet<Notificaciones> Notificaciones { get; set; }

    public virtual DbSet<Objetos> Objetos { get; set; }

    public virtual DbSet<Parametros> Parametros { get; set; }

    public virtual DbSet<Parentescos> Parentescos { get; set; }

    public virtual DbSet<Permisos> Permisos { get; set; }

    public virtual DbSet<Personas> Personas { get; set; }

    public virtual DbSet<RegistroViaje> RegistroViaje { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Rutas> Rutas { get; set; }

    public virtual DbSet<Secciones> Secciones { get; set; }

    public virtual DbSet<TipoContacto> TipoContacto { get; set; }

    public virtual DbSet<TipoPersonas> TipoPersonas { get; set; }

    public virtual DbSet<TipoViaje> TipoViaje { get; set; }

    public virtual DbSet<Unidades> Unidades { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    public virtual DbSet<Viajes> Viajes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bitacora>(entity =>
        {
            entity.HasKey(e => e.IdBitacora).HasName("PK__BITACORA__44E70BF3E55560D2");

            entity.ToTable("BITACORA");

            entity.Property(e => e.IdBitacora).HasColumnName("ID_BITACORA");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            entity.Property(e => e.TipoAccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_ACCION");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Bitacora)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__BITACORA__ID_INS__52593CB8");

            //entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Bitacora)
            //    .HasForeignKey(d => d.IdUsuario)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__BITACORA__ID_USU__5165187F");
        });

        modelBuilder.Entity<Contactos>(entity =>
        {
            entity.HasKey(e => e.IdContacto).HasName("PK__CONTACTO__8806CC1F4C5270A9");

            entity.ToTable("CONTACTOS");

            entity.Property(e => e.IdContacto).HasColumnName("ID_CONTACTO");
            entity.Property(e => e.Avenida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AVENIDA");
            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOQUE");
            entity.Property(e => e.Calle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.Casa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdPersona).HasColumnName("ID_PERSONA");
            entity.Property(e => e.IdTipoContacto).HasColumnName("ID_TIPO_CONTACTO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Contactos)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__CONTACTOS__ID_IN__73BA3083");

            //entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Contactos)
            //    .HasForeignKey(d => d.IdPersona)
            //    .HasConstraintName("FK__CONTACTOS__ID_PE__74AE54BC");

            //entity.HasOne(d => d.IdTipoContactoNavigation).WithMany(p => p.Contactos)
            //    .HasForeignKey(d => d.IdTipoContacto)
            //    .HasConstraintName("FK__CONTACTOS__ID_TI__75A278F5");
        });

        modelBuilder.Entity<Grados>(entity =>
        {
            entity.HasKey(e => e.IdGrado).HasName("PK__GRADOS__B207F3231A6EDA0C");

            entity.ToTable("GRADOS");

            entity.Property(e => e.IdGrado).HasColumnName("ID_GRADO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.Grado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GRADO");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Grados)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__GRADOS__ID_INSTI__1BC821DD");
        });

        modelBuilder.Entity<Incidentes>(entity =>
        {
            entity.HasKey(e => e.IdIncidente).HasName("PK__INCIDENT__6DC5A77325918976");

            entity.ToTable("INCIDENTES");

            entity.Property(e => e.IdIncidente).HasColumnName("ID_INCIDENTE");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdViaje).HasColumnName("ID_VIAJE");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Incidentes)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__INCIDENTE__ID_IN__2DE6D218");

            //entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.Incidentes)
            //    .HasForeignKey(d => d.IdViaje)
            //    .HasConstraintName("FK__INCIDENTE__ID_VI__2EDAF651");
        });

        modelBuilder.Entity<InstitutoRoles>(entity =>
        {
            entity.HasKey(e => e.IdInstitutoRol).HasName("PK__INSTITUT__F48D85DCA89AB471");

            entity.ToTable("INSTITUTO_ROLES");

            entity.Property(e => e.IdInstitutoRol).HasColumnName("ID_INSTITUTO_ROL");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.InstitutoRoles)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__INSTITUTO__ID_IN__6754599E");

            //entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.InstitutoRoles)
            //    .HasForeignKey(d => d.IdRol)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__INSTITUTO__ID_RO__68487DD7");
        });

        modelBuilder.Entity<InstitutoUsuarios>(entity =>
        {
            entity.HasKey(e => e.IdInstitutoUsuario).HasName("PK__INSTITUT__74FAE9E1B152300B");

            entity.ToTable("INSTITUTO_USUARIOS");

            entity.Property(e => e.IdInstitutoUsuario).HasColumnName("ID_INSTITUTO_USUARIO");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.InstitutoUsuarios)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__INSTITUTO__ID_IN__60A75C0F");

            //entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.InstitutoUsuarios)
            //    .HasForeignKey(d => d.IdUsuario)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__INSTITUTO__ID_US__619B8048");
        });

        modelBuilder.Entity<Institutos>(entity =>
        {
            entity.HasKey(e => e.IdInstituto).HasName("PK__INSTITUT__E031A83A11780ADE");

            entity.ToTable("INSTITUTOS");

            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.NombreInstituto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_INSTITUTO");
            entity.Property(e => e.Rtn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RTN");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Marcas>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__MARCAS__A9FDC4BB508D2493");

            entity.ToTable("MARCAS");

            entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.NombreMarca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MARCA");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Marcas)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__MARCAS__ID_INSTI__02FC7413");
        });

        modelBuilder.Entity<Modelos>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("PK__MODELOS__26C704A05D1D0C39");

            entity.ToTable("MODELOS");

            entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.NombreModelo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_MODELO");

            //entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Modelos)
            //    .HasForeignKey(d => d.IdMarca)
            //    .HasConstraintName("FK__MODELOS__ID_MARC__07C12930");
        });

        modelBuilder.Entity<Notificaciones>(entity =>
        {
            entity.HasKey(e => e.IdNotificacion).HasName("PK__NOTIFICA__363ED10784BA9EA5");

            entity.ToTable("NOTIFICACIONES");

            entity.Property(e => e.IdNotificacion).HasColumnName("ID_NOTIFICACION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdPersona).HasColumnName("ID_PERSONA");
            entity.Property(e => e.Mensaje)
                .IsUnicode(false)
                .HasColumnName("MENSAJE");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Notificaciones)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__NOTIFICAC__FECHA__3864608B");

            //entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Notificaciones)
            //    .HasForeignKey(d => d.IdPersona)
            //    .HasConstraintName("FK__NOTIFICAC__ID_PE__395884C4");
        });

        modelBuilder.Entity<Objetos>(entity =>
        {
            entity.HasKey(e => e.IdObjeto).HasName("PK__OBJETOS__6F0599673335FDC3");

            entity.ToTable("OBJETOS");

            entity.Property(e => e.IdObjeto).HasColumnName("ID_OBJETO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.Objeto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.TipoObjeto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_OBJETO");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Objetos)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__OBJETOS__ID_INST__571DF1D5");
        });

        modelBuilder.Entity<Parametros>(entity =>
        {
            entity.HasKey(e => e.IdParametro).HasName("PK__PARAMETR__79032FF56F779CB9");

            entity.ToTable("PARAMETROS");

            entity.Property(e => e.IdParametro).HasColumnName("ID_PARAMETRO");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.Parametro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARAMETRO");
            entity.Property(e => e.Valor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VALOR");

            //entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Parametros)
            //    .HasForeignKey(d => d.IdUsuario)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__PARAMETRO__ID_US__6477ECF3");
        });

        modelBuilder.Entity<Parentescos>(entity =>
        {
            entity.HasKey(e => e.IdParentesco).HasName("PK__PARENTES__07B211C643E5A94D");

            entity.ToTable("PARENTESCOS");

            entity.Property(e => e.IdParentesco).HasColumnName("ID_PARENTESCO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdPersonaAlumno).HasColumnName("ID_PERSONA_ALUMNO");
            entity.Property(e => e.IdPersonaResponsable).HasColumnName("ID_PERSONA_RESPONSABLE");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.Parentesco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARENTESCO");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Parentescos)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__PARENTESC__ID_IN__339FAB6E");

            //entity.HasOne(d => d.IdPersonaAlumnoNavigation).WithMany(p => p.ParentescosIdPersonaAlumnoNavigation)
            //    .HasForeignKey(d => d.IdPersonaAlumno)
            //    .HasConstraintName("FK__PARENTESC__ID_PE__3493CFA7");

            //entity.HasOne(d => d.IdPersonaResponsableNavigation).WithMany(p => p.ParentescosIdPersonaResponsableNavigation)
            //    .HasForeignKey(d => d.IdPersonaResponsable)
            //    .HasConstraintName("FK__PARENTESC__ID_PE__3587F3E0");
        });

        modelBuilder.Entity<Permisos>(entity =>
        {
            entity.HasKey(e => e.IdPermiso).HasName("PK__PERMISOS__AC74EBF6D7F3647B");

            entity.ToTable("PERMISOS");

            entity.Property(e => e.IdPermiso).HasColumnName("ID_PERMISO");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdObjeto).HasColumnName("ID_OBJETO");
            entity.Property(e => e.IdRol).HasColumnName("ID_ROL");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.Permiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERMISO");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Permisos)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__PERMISOS__ID_INS__5DCAEF64");

            //entity.HasOne(d => d.IdObjetoNavigation).WithMany(p => p.Permisos)
            //    .HasForeignKey(d => d.IdObjeto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__PERMISOS__ID_OBJ__5CD6CB2B");

            //entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Permisos)
            //    .HasForeignKey(d => d.IdRol)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__PERMISOS__ID_ROL__5BE2A6F2");
        });

        modelBuilder.Entity<Personas>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__PERSONAS__78244149A2CB5E92");

            entity.ToTable("PERSONAS");

            entity.Property(e => e.IdPersona).HasColumnName("ID_PERSONA");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.FechaNacimiento).HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Genero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdTipoPersona).HasColumnName("ID_TIPO_PERSONA");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PRIMER_APELLIDO");
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PRIMER_NOMBRE");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SEGUNDO_APELLIDO");
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SEGUNDO_NOMBRE");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Personas)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__PERSONAS__ID_INS__412EB0B6");

            //entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Personas)
            //    .HasForeignKey(d => d.IdTipoPersona)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__PERSONAS__ID_TIP__4222D4EF");
        });

        modelBuilder.Entity<RegistroViaje>(entity =>
        {
            entity.HasKey(e => e.IdRegistroViaje).HasName("PK__REGISTRO__E4863FD9C80C4F5B");

            entity.ToTable("REGISTRO_VIAJE");

            entity.Property(e => e.IdRegistroViaje).HasColumnName("ID_REGISTRO_VIAJE");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdPersonaAlumno).HasColumnName("ID_PERSONA_ALUMNO");
            entity.Property(e => e.IdRuta).HasColumnName("ID_RUTA");
            entity.Property(e => e.IdViaje).HasColumnName("ID_VIAJE");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.RegistroViaje)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__REGISTRO___ID_IN__2645B050");

            //entity.HasOne(d => d.IdPersonaAlumnoNavigation).WithMany(p => p.RegistroViaje)
            //    .HasForeignKey(d => d.IdPersonaAlumno)
            //    .HasConstraintName("FK__REGISTRO___ID_PE__2739D489");

            //entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.RegistroViaje)
            //    .HasForeignKey(d => d.IdRuta)
            //    .HasConstraintName("FK__REGISTRO___ID_RU__282DF8C2");

            //entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.RegistroViaje)
            //    .HasForeignKey(d => d.IdViaje)
            //    .HasConstraintName("FK__REGISTRO___ID_VI__29221CFB");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__ROLES__203B0F68D2C5EC61");

            entity.ToTable("ROLES");

            entity.Property(e => e.IdRol).HasColumnName("ID_ROL");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Roles)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__ROLES__ID_INSTIT__46E78A0C");
        });

        modelBuilder.Entity<Rutas>(entity =>
        {
            entity.HasKey(e => e.IdRuta).HasName("PK__RUTAS__CC5070219C3340CA");

            entity.ToTable("RUTAS");

            entity.Property(e => e.IdRuta).HasColumnName("ID_RUTA");
            entity.Property(e => e.Colonias)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("COLONIAS");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESTINO");
            entity.Property(e => e.DistanciaRecorrida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DISTANCIA_RECORRIDA");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MUNICIPIO");
            entity.Property(e => e.NombreRuta)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_RUTA");
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORIGEN");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Rutas)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__RUTAS__ID_INSTIT__7A672E12");
        });

        modelBuilder.Entity<Secciones>(entity =>
        {
            entity.HasKey(e => e.IdSeccion).HasName("PK__SECCIONE__2A128F0BB206FBC0");

            entity.ToTable("SECCIONES");

            entity.Property(e => e.IdSeccion).HasColumnName("ID_SECCION");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdGrado).HasColumnName("ID_GRADO");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.Seccion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SECCION");

            //entity.HasOne(d => d.IdGradoNavigation).WithMany(p => p.Secciones)
            //    .HasForeignKey(d => d.IdGrado)
            //    .HasConstraintName("FK__SECCIONES__ID_GR__2180FB33");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Secciones)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__SECCIONES__ID_IN__208CD6FA");
        });

        modelBuilder.Entity<TipoContacto>(entity =>
        {
            entity.HasKey(e => e.IdTipoContacto).HasName("PK__TIPO_CON__E4DAA52915E3B688");

            entity.ToTable("TIPO_CONTACTO");

            entity.Property(e => e.IdTipoContacto).HasColumnName("ID_TIPO_CONTACTO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
        });

        modelBuilder.Entity<TipoPersonas>(entity =>
        {
            entity.HasKey(e => e.IdTipoPersona).HasName("PK__TIPO_PER__E007574A71D77A60");

            entity.ToTable("TIPO_PERSONAS");

            entity.Property(e => e.IdTipoPersona).HasColumnName("ID_TIPO_PERSONA");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_PERSONA");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.TipoPersonas)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__TIPO_PERS__ID_IN__3C69FB99");
        });

        modelBuilder.Entity<TipoViaje>(entity =>
        {
            entity.HasKey(e => e.IdTipoViaje).HasName("PK__TIPO_VIA__3C4038C907912EE5");

            entity.ToTable("TIPO_VIAJE");

            entity.Property(e => e.IdTipoViaje).HasColumnName("ID_TIPO_VIAJE");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EVENTO");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
        });

        modelBuilder.Entity<Unidades>(entity =>
        {
            entity.HasKey(e => e.IdUnidad).HasName("PK__UNIDADES__F9DD852A0A857E35");

            entity.ToTable("UNIDADES");

            entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");
            entity.Property(e => e.Capacidad).HasColumnName("CAPACIDAD");
            entity.Property(e => e.Chasis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHASIS");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");
            entity.Property(e => e.IdModelo).HasColumnName("ID_MODELO");
            entity.Property(e => e.IdPersonaConductor).HasColumnName("ID_PERSONA_CONDUCTOR");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.NumeroUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NUMERO_UNIDAD");
            entity.Property(e => e.Placa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLACA");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Unidades)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__UNIDADES__ID_INS__0F624AF8");

            //entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.UnidadesIdMarcaNavigation)
            //    .HasForeignKey(d => d.IdMarca)
            //    .HasConstraintName("FK__UNIDADES__ID_MAR__0E6E26BF");

            //entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Unidades)
            //    .HasForeignKey(d => d.IdModelo)
            //    .HasConstraintName("FK__UNIDADES__ID_MOD__0D7A0286");

            //entity.HasOne(d => d.IdPersonaConductorNavigation).WithMany(p => p.UnidadesIdPersonaConductorNavigation)
            //    .HasForeignKey(d => d.IdPersonaConductor)
            //    .HasConstraintName("FK__UNIDADES__ID_PER__0C85DE4D");
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIOS__91136B90BDB3BB42");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONTRASEÑA");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.FechaUltimaConexion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ULTIMA_CONEXION");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdPersona).HasColumnName("ID_PERSONA");
            entity.Property(e => e.IdRol).HasColumnName("ID_ROL");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Usuarios)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__USUARIOS__ID_INS__4CA06362");

            //entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
            //    .HasForeignKey(d => d.IdPersona)
            //    .HasConstraintName("FK__USUARIOS__ID_PER__4BAC3F29");

            //entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
            //    .HasForeignKey(d => d.IdRol)
            //    .HasConstraintName("FK__USUARIOS__ID_ROL__4D94879B");
        });

        modelBuilder.Entity<Viajes>(entity =>
        {
            entity.HasKey(e => e.IdViaje).HasName("PK__VIAJES__13250BF896994D4C");

            entity.ToTable("VIAJES");

            entity.Property(e => e.IdViaje).HasColumnName("ID_VIAJE");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("COMENTARIOS");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CREADO_POR");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.FechaDeCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            entity.Property(e => e.FechaDeModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_MODIFICACION");
            entity.Property(e => e.HoraFinal).HasColumnName("HORA_FINAL");
            entity.Property(e => e.HoraInicio).HasColumnName("HORA_INICIO");
            entity.Property(e => e.IdInstituto).HasColumnName("ID_INSTITUTO");
            entity.Property(e => e.IdPersonaConductor).HasColumnName("ID_PERSONA_CONDUCTOR");
            entity.Property(e => e.IdPersonaNinera).HasColumnName("ID_PERSONA_NINERA");
            entity.Property(e => e.IdUnidad).HasColumnName("ID_UNIDAD");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODIFICADO_POR");

            //entity.HasOne(d => d.IdInstitutoNavigation).WithMany(p => p.Viajes)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__VIAJES__ID_INSTI__14270015");

            //entity.HasOne(d => d.IdPersonaConductorNavigation).WithMany(p => p.ViajesIdPersonaConductorNavigation)
            //    .HasForeignKey(d => d.IdPersonaConductor)
            //    .HasConstraintName("FK__VIAJES__ID_PERSO__151B244E");

            //entity.HasOne(d => d.IdPersonaNineraNavigation).WithMany(p => p.ViajesIdPersonaNineraNavigation)
            //    .HasForeignKey(d => d.IdPersonaNinera)
            //    .HasConstraintName("FK__VIAJES__ID_PERSO__160F4887");

            //entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Viajes)
            //    .HasForeignKey(d => d.IdUnidad)
            //    .HasConstraintName("FK__VIAJES__ID_UNIDA__17036CC0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
