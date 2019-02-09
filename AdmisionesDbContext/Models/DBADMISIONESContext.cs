using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdmisionesDbContext.Models
{
    public partial class DBADMISIONESContext : DbContext
    {
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Aulas> Aulas { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Evaluaciones> Evaluaciones { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Notificaciones> Notificaciones { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<Proceso> Proceso { get; set; }
        public virtual DbSet<Procesos> Procesos { get; set; }
        public virtual DbSet<SolicitudAdmisiones> SolicitudAdmisiones { get; set; }
        public virtual DbSet<UsuariosAdmin> UsuariosAdmin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=WINDOWS-N0UF27K\SQLEXPRESS; Database=DBADMISIONES; Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.TipoUsuario).HasColumnName("Tipo_Usuario");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Aulas>(entity =>
            {
                entity.HasKey(e => e.IdAula);

                entity.Property(e => e.IdAula)
                    .HasColumnName("ID_Aula")
                    .ValueGeneratedNever();

                entity.Property(e => e.Curso).IsRequired();

                entity.Property(e => e.IdCurso)
                    .IsRequired()
                    .HasColumnName("ID_Curso");

                entity.Property(e => e.Nivel).IsRequired();

                entity.Property(e => e.NombreAula)
                    .IsRequired()
                    .HasColumnName("Nombre_Aula");

                entity.Property(e => e.Ubicacion).IsRequired();
            });

            modelBuilder.Entity<Cursos>(entity =>
            {
                entity.HasKey(e => e.IdCurso);

                entity.Property(e => e.IdCurso)
                    .HasColumnName("ID_Curso")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nivel).IsRequired();

                entity.Property(e => e.NombreCurso)
                    .IsRequired()
                    .HasColumnName("Nombre_Curso");
            });

            modelBuilder.Entity<Evaluaciones>(entity =>
            {
                entity.HasKey(e => e.IdEvaluacion);

                entity.Property(e => e.IdEvaluacion).HasColumnName("ID_Evaluacion");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.NombreEvaluacion).HasColumnName("Nombre_Evaluacion");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.HasKey(e => e.IdNivel);

                entity.Property(e => e.IdNivel).HasColumnName("ID_Nivel");

                entity.Property(e => e.NombreNivel)
                    .IsRequired()
                    .HasColumnName("Nombre_Nivel");
            });

            modelBuilder.Entity<Notificaciones>(entity =>
            {
                entity.HasKey(e => e.IdNotificacion);

                entity.Property(e => e.IdNotificacion).HasColumnName("ID_Notificacion");

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.Estado).IsRequired();

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Titulo).IsRequired();
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.Property(e => e.IdPago).HasColumnName("ID_Pago");

                entity.Property(e => e.Concepto).IsRequired();

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Recibe).IsRequired();

                entity.Property(e => e.Usuario).IsRequired();
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasKey(e => e.IdPeriodo);

                entity.Property(e => e.IdPeriodo).HasColumnName("ID_Periodo");

                entity.Property(e => e.PeriodoEscolar)
                    .IsRequired()
                    .HasColumnName("Periodo_Escolar");
            });

            modelBuilder.Entity<Proceso>(entity =>
            {
                entity.HasKey(e => e.IdPoces);

                entity.ToTable("proceso");

                entity.Property(e => e.IdPoces).HasColumnName("ID_Poces");

                entity.Property(e => e.Estado).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();
            });

            modelBuilder.Entity<Procesos>(entity =>
            {
                entity.HasKey(e => e.IdProceso);

                entity.Property(e => e.IdProceso).HasColumnName("ID_Proceso");

                entity.Property(e => e.Estado).IsRequired();

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.NombreProceso)
                    .IsRequired()
                    .HasColumnName("Nombre_Proceso");
            });

            modelBuilder.Entity<SolicitudAdmisiones>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("Solicitud_Admisiones");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ_CORREO")
                    .IsUnique();

                entity.HasIndex(e => e.Usuario)
                    .HasName("UQ_Usuario")
                    .IsUnique();

                entity.Property(e => e.IdSolicitud).HasColumnName("ID_Solicitud");

                entity.Property(e => e.Apellido).IsRequired();

                entity.Property(e => e.Aula).IsRequired();

                entity.Property(e => e.CentroProcedencia)
                    .IsRequired()
                    .HasColumnName("Centro_Procedencia");

                entity.Property(e => e.Curso).IsRequired();

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSolicitud)
                    .IsRequired()
                    .HasColumnName("Estado_Solicitud");

                entity.Property(e => e.FechaNacimiento)
                    .IsRequired()
                    .HasColumnName("Fecha_Nacimiento");

                entity.Property(e => e.FechaSolicitud).HasColumnName("Fecha_Solicitud");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LugarNacimiento)
                    .IsRequired()
                    .HasColumnName("Lugar_Nacimiento");

                entity.Property(e => e.Nivel).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();

                entity.Property(e => e.NombreMadre)
                    .IsRequired()
                    .HasColumnName("Nombre_Madre");

                entity.Property(e => e.NombrePadre)
                    .IsRequired()
                    .HasColumnName("Nombre_Padre");

                entity.Property(e => e.PeriodoEscolar)
                    .IsRequired()
                    .HasColumnName("Periodo_Escolar");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Tanda).IsRequired();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoPadres)
                    .IsRequired()
                    .HasColumnName("Telefono_Padres");

                entity.Property(e => e.UrlActaNacimiento).HasColumnName("URL_Acta_Nacimiento");

                entity.Property(e => e.UrlCertificadoMedico).HasColumnName("URL_Certificado_Medico");

                entity.Property(e => e.UrlFoto).HasColumnName("URL_Foto");

                entity.Property(e => e.UrlRecordNotas).HasColumnName("URL_Record_Notas");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuariosAdmin>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Apellido).IsRequired();

                entity.Property(e => e.Clave).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Imagen).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("Nombre_Usuario");

                entity.Property(e => e.ReferenciaClave)
                    .IsRequired()
                    .HasColumnName("Referencia_Clave");

                entity.Property(e => e.Telefono).IsRequired();

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasColumnName("Tipo_Usuario");
            });
        }
    }
}
