using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI1.Models
{
    public partial class ESTUDIANTESContext : DbContext
    {
        public ESTUDIANTESContext()
        {
        }

        public ESTUDIANTESContext(DbContextOptions<ESTUDIANTESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ESTUDIANTES;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Alumnos>(entity =>
            {
                entity.HasKey(e => e.IdAlumnos)
                    .HasName("PK__ALUMNOS__E27E48CBED8311B4");

                entity.ToTable("ALUMNOS");

                entity.Property(e => e.IdAlumnos).HasColumnName("ID_ALUMNOS");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .IsRequired()
                    .HasColumnName("FECHA_NACIMIENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaEspanol)
                    .HasColumnName("Materia_Espanol")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaMatematicas)
                    .HasColumnName("Materia_Matematicas")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaNaturales)
                    .HasColumnName("Materia_Naturales")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaSociales)
                    .HasColumnName("Materia_Sociales")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
