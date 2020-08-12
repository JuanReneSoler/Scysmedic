using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Persistence.Models;

namespace Persistence
{
    public partial class ScysmedicDbContext : DbContext
    {
        public ScysmedicDbContext()
        {
        }

        public ScysmedicDbContext(DbContextOptions<ScysmedicDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Cargo1> Cargo1 { get; set; }
        public virtual DbSet<Cargo2> Cargo2 { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<CompraDetalle> CompraDetalle { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empleado1> Empleado1 { get; set; }
        public virtual DbSet<Empleado2> Empleado2 { get; set; }
        public virtual DbSet<EmpleadoEspecialidad> EmpleadoEspecialidad { get; set; }
        public virtual DbSet<EmpleadoHistorial> EmpleadoHistorial { get; set; }
        public virtual DbSet<EmpleadoHistorial1> EmpleadoHistorial1 { get; set; }
        public virtual DbSet<EmpleadoHistorial2> EmpleadoHistorial2 { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Farmacia> Farmacia { get; set; }
        public virtual DbSet<FarmaciaUser> FarmaciaUser { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<HospitalEmpleadoUser> HospitalEmpleadoUser { get; set; }
        public virtual DbSet<HospitalUser> HospitalUser { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<LaboratorioUser> LaboratorioUser { get; set; }
        public virtual DbSet<Medicamento> Medicamento { get; set; }
        public virtual DbSet<MedicamentoHostorial> MedicamentoHostorial { get; set; }
        public virtual DbSet<MotivoDevolucion> MotivoDevolucion { get; set; }
        public virtual DbSet<Receta> Receta { get; set; }
        public virtual DbSet<RecetaDetalle> RecetaDetalle { get; set; }
        public virtual DbSet<Resultado> Resultado { get; set; }
        public virtual DbSet<Suplidor> Suplidor { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoEmpresa> TipoEmpresa { get; set; }
        public virtual DbSet<TipoMedicamento> TipoMedicamento { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=ScysmedicDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.ToTable("AspNetRoleClaims", "Identity");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.ToTable("AspNetRoles", "Identity");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.ToTable("AspNetUserClaims", "Identity");

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

                entity.ToTable("AspNetUserLogins", "Identity");

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

                entity.ToTable("AspNetUserRoles", "Identity");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("AspNetUserTokens", "Identity");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.ToTable("AspNetUsers", "Identity");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("Cargo", "Farmacias");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cargo1>(entity =>
            {
                entity.ToTable("Cargo", "Hospitales");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cargo2>(entity =>
            {
                entity.ToTable("Cargo", "Laboratorios");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Citas>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Citas)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Citas__EmpleadoI__06CD04F7");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Citas)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Citas__HospitalI__07C12930");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Citas)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Citas__UserId__08B54D69");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.ToTable("Compra", "App");

                entity.Property(e => e.CodigoVerificacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Farmacia)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.FarmaciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__Farmacia__70DDC3D8");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.RecetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__RecetaId__71D1E811");

                entity.HasOne(d => d.TipoPagoNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.TipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__TipoPago__72C60C4A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Compra__UserId__73BA3083");
            });

            modelBuilder.Entity<CompraDetalle>(entity =>
            {
                entity.ToTable("CompraDetalle", "App");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.HasOne(d => d.Compra)
                    .WithMany(p => p.CompraDetalle)
                    .HasForeignKey(d => d.CompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompraDet__Compr__74AE54BC");

                entity.HasOne(d => d.MedicamentoReceta)
                    .WithMany(p => p.CompraDetalle)
                    .HasForeignKey(d => d.MedicamentoRecetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompraDet__Medic__75A278F5");

                entity.HasOne(d => d.MotivoDevolucion)
                    .WithMany(p => p.CompraDetalle)
                    .HasForeignKey(d => d.MotivoDevolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompraDet__Motiv__76969D2E");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.ToTable("Documento", "Repository");

                entity.Property(e => e.Formato).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado", "Farmacias");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoIdentidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado__TipoDo__09A971A2");
            });

            modelBuilder.Entity<Empleado1>(entity =>
            {
                entity.ToTable("Empleado", "Hospitales");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoIdentidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Empleado1)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado__TipoDo__114A936A");
            });

            modelBuilder.Entity<Empleado2>(entity =>
            {
                entity.ToTable("Empleado", "Laboratorios");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoIdentidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Empleado2)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado__TipoDo__1DB06A4F");
            });

            modelBuilder.Entity<EmpleadoEspecialidad>(entity =>
            {
                entity.ToTable("EmpleadoEspecialidad", "Hospitales");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.EmpleadoEspecialidad)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoE__Emple__123EB7A3");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.EmpleadoEspecialidad)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoE__Espec__1332DBDC");
            });

            modelBuilder.Entity<EmpleadoHistorial>(entity =>
            {
                entity.ToTable("EmpleadoHistorial", "Farmacias");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.EmpleadoHistorial)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Cargo__0A9D95DB");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.EmpleadoHistorial)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Emple__0B91BA14");

                entity.HasOne(d => d.Farmacia)
                    .WithMany(p => p.EmpleadoHistorial)
                    .HasForeignKey(d => d.FarmaciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Farma__0C85DE4D");
            });

            modelBuilder.Entity<EmpleadoHistorial1>(entity =>
            {
                entity.ToTable("EmpleadoHistorial", "Hospitales");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.EmpleadoHistorial1)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Cargo__14270015");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.EmpleadoHistorial1)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Emple__151B244E");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.EmpleadoHistorial1)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Labor__160F4887");
            });

            modelBuilder.Entity<EmpleadoHistorial2>(entity =>
            {
                entity.ToTable("EmpleadoHistorial", "Laboratorios");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.EmpleadoHistorial2)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Cargo__1EA48E88");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.EmpleadoHistorial2)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Emple__1F98B2C1");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.EmpleadoHistorial2)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmpleadoH__Labor__208CD6FA");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("Especialidad", "Hospitales");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Farmacia>(entity =>
            {
                entity.ToTable("Farmacia", "Farmacias");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarmaciaUser>(entity =>
            {
                entity.ToTable("FarmaciaUser", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Farmacia)
                    .WithMany(p => p.FarmaciaUser)
                    .HasForeignKey(d => d.FarmaciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FarmaciaU__Farma__778AC167");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FarmaciaUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FarmaciaU__UserI__787EE5A0");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("Hospital", "Hospitales");

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoEmpresa)
                    .WithMany(p => p.Hospital)
                    .HasForeignKey(d => d.TipoEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Hospital__TipoEm__17036CC0");
            });

            modelBuilder.Entity<HospitalEmpleadoUser>(entity =>
            {
                entity.ToTable("HospitalEmpleadoUser", "App");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.HospitalEmpleadoUser)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Emple__797309D9");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.HospitalEmpleadoUser)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Espec__7A672E12");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalEmpleadoUser)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Hospi__7B5B524B");
            });

            modelBuilder.Entity<HospitalUser>(entity =>
            {
                entity.ToTable("HospitalUser", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalUser)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalU__Hospi__7C4F7684");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HospitalUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__HospitalU__UserI__7D439ABD");
            });

            modelBuilder.Entity<Laboratorio>(entity =>
            {
                entity.ToTable("Laboratorio", "Laboratorios");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionLatitud)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionLongitud)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoEmpresa)
                    .WithMany(p => p.Laboratorio)
                    .HasForeignKey(d => d.TipoEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__TipoE__2180FB33");
            });

            modelBuilder.Entity<LaboratorioUser>(entity =>
            {
                entity.ToTable("LaboratorioUser", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.LaboratorioUser)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__Labor__7E37BEF6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LaboratorioUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Laborator__UserI__7F2BE32F");
            });

            modelBuilder.Entity<Medicamento>(entity =>
            {
                entity.ToTable("Medicamento", "Farmacias");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoMedicamento)
                    .WithMany(p => p.Medicamento)
                    .HasForeignKey(d => d.TipoMedicamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicamen__TipoM__0D7A0286");
            });

            modelBuilder.Entity<MedicamentoHostorial>(entity =>
            {
                entity.ToTable("MedicamentoHostorial", "Farmacias");

                entity.HasOne(d => d.Medicamento)
                    .WithMany(p => p.MedicamentoHostorial)
                    .HasForeignKey(d => d.MedicamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicamen__Medic__0E6E26BF");

                entity.HasOne(d => d.Suplidor)
                    .WithMany(p => p.MedicamentoHostorial)
                    .HasForeignKey(d => d.SuplidorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicamen__Supli__0F624AF8");
            });

            modelBuilder.Entity<MotivoDevolucion>(entity =>
            {
                entity.ToTable("MotivoDevolucion", "Shared");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Receta>(entity =>
            {
                entity.ToTable("Receta", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Receta)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Receta__Empleado__00200768");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Receta)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Receta__UserId__01142BA1");
            });

            modelBuilder.Entity<RecetaDetalle>(entity =>
            {
                entity.ToTable("RecetaDetalle", "App");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Medicamento)
                    .WithMany(p => p.RecetaDetalle)
                    .HasForeignKey(d => d.MedicamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RecetaDet__Medic__02084FDA");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.RecetaDetalle)
                    .HasForeignKey(d => d.RecetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RecetaDet__Recet__02FC7413");
            });

            modelBuilder.Entity<Resultado>(entity =>
            {
                entity.ToTable("Resultado", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Documento)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.DocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Resultado__Docum__03F0984C");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Resultado__Labor__04E4BC85");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Resultado__UserI__05D8E0BE");
            });

            modelBuilder.Entity<Suplidor>(entity =>
            {
                entity.ToTable("Suplidor", "Farmacias");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionLatitud)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionLongitud)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoEmpresa)
                    .WithMany(p => p.Suplidor)
                    .HasForeignKey(d => d.TipoEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Suplidor__TipoEm__10566F31");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("TipoDocumento", "Shared");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEmpresa>(entity =>
            {
                entity.ToTable("TipoEmpresa", "Shared");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Siglas)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMedicamento>(entity =>
            {
                entity.ToTable("TipoMedicamento", "Farmacias");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.ToTable("TipoPago", "Shared");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
