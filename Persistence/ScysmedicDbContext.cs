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

        public virtual DbSet<Aseguradora> Aseguradora { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<CompraDetalle> CompraDetalle { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Farmacia> Farmacia { get; set; }
        public virtual DbSet<FarmaciaCargo> FarmaciaCargo { get; set; }
        public virtual DbSet<FarmaciaEmpleado> FarmaciaEmpleado { get; set; }
        public virtual DbSet<FarmaciaEmpleadoHistorial> FarmaciaEmpleadoHistorial { get; set; }
        public virtual DbSet<FarmaciaUser> FarmaciaUser { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<HospitalCargo> HospitalCargo { get; set; }
        public virtual DbSet<HospitalEmpleado> HospitalEmpleado { get; set; }
        public virtual DbSet<HospitalEmpleadoEspecialidad> HospitalEmpleadoEspecialidad { get; set; }
        public virtual DbSet<HospitalEmpleadoHistorial> HospitalEmpleadoHistorial { get; set; }
        public virtual DbSet<HospitalEmpleadoUser> HospitalEmpleadoUser { get; set; }
        public virtual DbSet<HospitalUser> HospitalUser { get; set; }
        public virtual DbSet<InformacionPersonal> InformacionPersonal { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<LaboratorioCargo> LaboratorioCargo { get; set; }
        public virtual DbSet<LaboratorioEmpleado> LaboratorioEmpleado { get; set; }
        public virtual DbSet<LaboratorioEmpleadoHistorial> LaboratorioEmpleadoHistorial { get; set; }
        public virtual DbSet<LaboratorioUser> LaboratorioUser { get; set; }
        public virtual DbSet<Medicamento> Medicamento { get; set; }
        public virtual DbSet<MedicamentoHostorial> MedicamentoHostorial { get; set; }
        public virtual DbSet<MotivoDevolucion> MotivoDevolucion { get; set; }
        public virtual DbSet<Receta> Receta { get; set; }
        public virtual DbSet<RecetaDetalle> RecetaDetalle { get; set; }
        public virtual DbSet<Resultado> Resultado { get; set; }
        public virtual DbSet<SeguroHistorial> SeguroHistorial { get; set; }
        public virtual DbSet<Suplidor> Suplidor { get; set; }
        public virtual DbSet<TargetaVinculadas> TargetaVinculadas { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoEmpresa> TipoEmpresa { get; set; }
        public virtual DbSet<TipoMedicamento> TipoMedicamento { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<TipoTargeta> TipoTargeta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=ScysmedicDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aseguradora>(entity =>
            {
                entity.ToTable("Aseguradora", "Shared");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.ToTable("Banco", "Shared");

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rnc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Siglas)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Citas>(entity =>
            {
                entity.ToTable("Citas", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Citas)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Citas__EmpleadoI__0B91BA14");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Citas)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Citas__HospitalI__0A9D95DB");
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
                    .HasConstraintName("FK__Compra__Farmacia__01142BA1");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.RecetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__RecetaId__02084FDA");

                entity.HasOne(d => d.TipoPagoNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.TipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__TipoPago__02FC7413");
            });

            modelBuilder.Entity<CompraDetalle>(entity =>
            {
                entity.ToTable("CompraDetalle", "App");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.HasOne(d => d.Compra)
                    .WithMany(p => p.CompraDetalle)
                    .HasForeignKey(d => d.CompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompraDet__Compr__05D8E0BE");

                entity.HasOne(d => d.MedicamentoReceta)
                    .WithMany(p => p.CompraDetalle)
                    .HasForeignKey(d => d.MedicamentoRecetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompraDet__Medic__06CD04F7");

                entity.HasOne(d => d.MotivoDevolucion)
                    .WithMany(p => p.CompraDetalle)
                    .HasForeignKey(d => d.MotivoDevolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompraDet__Motiv__07C12930");
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

            modelBuilder.Entity<FarmaciaCargo>(entity =>
            {
                entity.ToTable("FarmaciaCargo", "Farmacias");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarmaciaEmpleado>(entity =>
            {
                entity.ToTable("FarmaciaEmpleado", "Farmacias");

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
                    .WithMany(p => p.FarmaciaEmpleado)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FarmaciaE__TipoD__398D8EEE");
            });

            modelBuilder.Entity<FarmaciaEmpleadoHistorial>(entity =>
            {
                entity.ToTable("FarmaciaEmpleadoHistorial", "Farmacias");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.FarmaciaEmpleadoHistorial)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FarmaciaE__Cargo__3D5E1FD2");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.FarmaciaEmpleadoHistorial)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FarmaciaE__Emple__3C69FB99");

                entity.HasOne(d => d.Farmacia)
                    .WithMany(p => p.FarmaciaEmpleadoHistorial)
                    .HasForeignKey(d => d.FarmaciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FarmaciaE__Farma__3E52440B");
            });

            modelBuilder.Entity<FarmaciaUser>(entity =>
            {
                entity.ToTable("FarmaciaUser", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Farmacia)
                    .WithMany(p => p.FarmaciaUser)
                    .HasForeignKey(d => d.FarmaciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FarmaciaU__Farma__693CA210");
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
                    .HasConstraintName("FK__Hospital__TipoEm__59063A47");
            });

            modelBuilder.Entity<HospitalCargo>(entity =>
            {
                entity.ToTable("HospitalCargo", "Hospitales");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HospitalEmpleado>(entity =>
            {
                entity.ToTable("HospitalEmpleado", "Hospitales");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocId)
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
                    .WithMany(p => p.HospitalEmpleado)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__TipoD__5BE2A6F2");
            });

            modelBuilder.Entity<HospitalEmpleadoEspecialidad>(entity =>
            {
                entity.ToTable("HospitalEmpleadoEspecialidad", "Hospitales");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.HospitalEmpleadoEspecialidad)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Emple__656C112C");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.HospitalEmpleadoEspecialidad)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Espec__66603565");
            });

            modelBuilder.Entity<HospitalEmpleadoHistorial>(entity =>
            {
                entity.ToTable("HospitalEmpleadoHistorial", "Hospitales");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.HospitalEmpleadoHistorial)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Cargo__5FB337D6");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.HospitalEmpleadoHistorial)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Emple__5EBF139D");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.HospitalEmpleadoHistorial)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Labor__60A75C0F");
            });

            modelBuilder.Entity<HospitalEmpleadoUser>(entity =>
            {
                entity.ToTable("HospitalEmpleadoUser", "App");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.HospitalEmpleadoUser)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Emple__72C60C4A");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.HospitalEmpleadoUser)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Espec__73BA3083");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalEmpleadoUser)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalE__Hospi__71D1E811");
            });

            modelBuilder.Entity<HospitalUser>(entity =>
            {
                entity.ToTable("HospitalUser", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalUser)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HospitalU__Hospi__6EF57B66");
            });

            modelBuilder.Entity<InformacionPersonal>(entity =>
            {
                entity.ToTable("InformacionPersonal", "App");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(450);
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
                    .HasConstraintName("FK__Laborator__TipoE__4CA06362");
            });

            modelBuilder.Entity<LaboratorioCargo>(entity =>
            {
                entity.ToTable("LaboratorioCargo", "Laboratorios");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaboratorioEmpleado>(entity =>
            {
                entity.ToTable("LaboratorioEmpleado", "Laboratorios");

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
                    .WithMany(p => p.LaboratorioEmpleado)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__TipoD__4F7CD00D");
            });

            modelBuilder.Entity<LaboratorioEmpleadoHistorial>(entity =>
            {
                entity.ToTable("LaboratorioEmpleadoHistorial", "Laboratorios");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.LaboratorioEmpleadoHistorial)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__Cargo__534D60F1");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.LaboratorioEmpleadoHistorial)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__Emple__52593CB8");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.LaboratorioEmpleadoHistorial)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__Labor__5441852A");
            });

            modelBuilder.Entity<LaboratorioUser>(entity =>
            {
                entity.ToTable("LaboratorioUser", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.LaboratorioUser)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborator__Labor__6C190EBB");
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
                    .HasConstraintName("FK__Medicamen__TipoM__440B1D61");
            });

            modelBuilder.Entity<MedicamentoHostorial>(entity =>
            {
                entity.ToTable("MedicamentoHostorial", "Farmacias");

                entity.HasOne(d => d.Medicamento)
                    .WithMany(p => p.MedicamentoHostorial)
                    .HasForeignKey(d => d.MedicamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicamen__Medic__46E78A0C");

                entity.HasOne(d => d.Suplidor)
                    .WithMany(p => p.MedicamentoHostorial)
                    .HasForeignKey(d => d.SuplidorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicamen__Supli__47DBAE45");
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
                    .HasConstraintName("FK__Receta__Empleado__76969D2E");
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
                    .HasConstraintName("FK__RecetaDet__Medic__7A672E12");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.RecetaDetalle)
                    .HasForeignKey(d => d.RecetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RecetaDet__Recet__797309D9");
            });

            modelBuilder.Entity<Resultado>(entity =>
            {
                entity.ToTable("Resultado", "App");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Documento)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.DocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Resultado__Docum__7E37BEF6");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.Resultado)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Resultado__Labor__7D439ABD");
            });

            modelBuilder.Entity<SeguroHistorial>(entity =>
            {
                entity.ToTable("SeguroHistorial", "App");

                entity.Property(e => e.NumeroSeguro)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Documento)
                    .WithMany(p => p.SeguroHistorial)
                    .HasForeignKey(d => d.DocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SeguroHis__Docum__151B244E");

                entity.HasOne(d => d.Seguro)
                    .WithMany(p => p.SeguroHistorial)
                    .HasForeignKey(d => d.SeguroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SeguroHis__Segur__14270015");
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
                    .HasConstraintName("FK__Suplidor__TipoEm__412EB0B6");
            });

            modelBuilder.Entity<TargetaVinculadas>(entity =>
            {
                entity.ToTable("TargetaVinculadas", "App");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Banco)
                    .WithMany(p => p.TargetaVinculadas)
                    .HasForeignKey(d => d.BancoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TargetaVi__Banco__10566F31");

                entity.HasOne(d => d.TipoTargeta)
                    .WithMany(p => p.TargetaVinculadas)
                    .HasForeignKey(d => d.TipoTargetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TargetaVi__TipoT__114A936A");
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

            modelBuilder.Entity<TipoTargeta>(entity =>
            {
                entity.ToTable("TipoTargeta", "Shared");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
