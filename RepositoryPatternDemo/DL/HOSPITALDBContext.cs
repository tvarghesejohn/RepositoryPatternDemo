using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RepositoryPatternDemo.DL
{
    public partial class HOSPITALDBContext : DbContext
    {
        public HOSPITALDBContext()
        {
        }

        public HOSPITALDBContext(DbContextOptions<HOSPITALDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=IN31GFRRL4149PW;Database=HOSPITALDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_Doctor");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Hospital");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.Property(e => e.HospitalName).IsRequired();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
