using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoAMBE.Data;

public partial class TransportedbContext : DbContext
{
    public TransportedbContext()
    {
    }

    public TransportedbContext(DbContextOptions<TransportedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bitacora> Bitacora { get; set; }

    public virtual DbSet<Institutos> Institutos { get; set; }

    public virtual DbSet<Objetos> Objetos { get; set; }

    public virtual DbSet<Parametros> Parametros { get; set; }

    public virtual DbSet<Permisos> Permisos { get; set; }

    public virtual DbSet<Personas> Personas { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<TipoPersonas> TipoPersonas { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bitacora>(entity =>
        {
            entity.HasKey(e => e.IdBitacora).HasName("PK__BITACORA__44E70BF37E33F19B");

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

        modelBuilder.Entity<Institutos>(entity =>
        {
            entity.HasKey(e => e.IdInstituto).HasName("PK__INSTITUT__E031A83A8B88E0A8");

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

            //entity.HasMany(d => d.IdRol).WithMany(p => p.IdInstitutoNavigation)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "InstitutoRoles",
            //        r => r.HasOne<Roles>().WithMany()
            //            .HasForeignKey("IdRol")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("FK__INSTITUTO__ID_RO__68487DD7"),
            //        l => l.HasOne<Institutos>().WithMany()
            //            .HasForeignKey("IdInstituto")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("FK__INSTITUTO__ID_IN__6754599E"),
            //        j =>
            //        {
            //            j.HasKey("IdInstituto", "IdRol").HasName("PK__INSTITUT__723218CC26D38021");
            //            j.ToTable("INSTITUTO_ROLES");
            //            j.IndexerProperty<int>("IdInstituto").HasColumnName("ID_INSTITUTO");
            //            j.IndexerProperty<int>("IdRol").HasColumnName("ID_ROL");
            //        });

            //entity.HasMany(d => d.IdUsuario).WithMany(p => p.IdInstitutoNavigation)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "InstitutoUsuarios",
            //        r => r.HasOne<Usuarios>().WithMany()
            //            .HasForeignKey("IdUsuario")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("FK__INSTITUTO__ID_US__619B8048"),
            //        l => l.HasOne<Institutos>().WithMany()
            //            .HasForeignKey("IdInstituto")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("FK__INSTITUTO__ID_IN__60A75C0F"),
            //        j =>
            //        {
            //            j.HasKey("IdInstituto", "IdUsuario").HasName("PK__INSTITUT__F9209E8305977FF4");
            //            j.ToTable("INSTITUTO_USUARIOS");
            //            j.IndexerProperty<int>("IdInstituto").HasColumnName("ID_INSTITUTO");
            //            j.IndexerProperty<int>("IdUsuario").HasColumnName("ID_USUARIO");
            //        });
        });

        modelBuilder.Entity<Objetos>(entity =>
        {
            entity.HasKey(e => e.IdObjeto).HasName("PK__OBJETOS__6F0599678F8C9B6A");

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
            entity.HasKey(e => e.IdParametro).HasName("PK__PARAMETR__79032FF56069A2B0");

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

        modelBuilder.Entity<Permisos>(entity =>
        {
            entity.HasKey(e => e.IdPermiso).HasName("PK__PERMISOS__AC74EBF6599FB0D1");

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
            entity.HasKey(e => e.IdPersona).HasName("PK__PERSONAS__78244149D07B5007");

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

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__ROLES__203B0F6856B1EE17");

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

            //entity.HasOne(d => d.IdInstituto1).WithMany(p => p.Roles)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__ROLES__ID_INSTIT__46E78A0C");
        });

        modelBuilder.Entity<TipoPersonas>(entity =>
        {
            entity.HasKey(e => e.IdTipoPersona).HasName("PK__TIPO_PER__E007574AFA2670AD");

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

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIOS__91136B90E64DBC12");

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

            //entity.HasOne(d => d.IdInstituto1).WithMany(p => p.Usuarios)
            //    .HasForeignKey(d => d.IdInstituto)
            //    .HasConstraintName("FK__USUARIOS__ID_INS__4CA06362");

            //entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
            //    .HasForeignKey(d => d.IdPersona)
            //    .HasConstraintName("FK__USUARIOS__ID_PER__4BAC3F29");

            //entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
            //    .HasForeignKey(d => d.IdRol)
            //    .HasConstraintName("FK__USUARIOS__ID_ROL__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
