using DSMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DSMS.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


       
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<AddressPatientViewModel> addressPatientViewModels { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<AddressPatientViewModel>().HasNoKey();
            // Configure one-to-one relationship between Patient and Address
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Address)
                .WithOne()
                .HasForeignKey<Patient>(p => p.AddressId);

            // Configure one-to-one relationship between Surgery and Address
            //modelBuilder.Entity<Surgery>()
            //    .HasOne(s => s.Address)
            //    .WithOne()
            //    .HasForeignKey<Surgery>(s => s.AddressId);


            
            //// Define relationships
            //modelBuilder.Entity<Appointment>()
            //    .HasOne(a => a.dentist)
            //    .WithMany(d => d.Appointments)
            //    .HasForeignKey(a => a.DentistId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Appointment>()
            //    .HasOne(a => a.patient)
            //    .WithMany(p => p.Appointments)
            //    .HasForeignKey(a => a.PatientId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Appointment>()
            //    .HasOne(a => a.surgery)
            //    .WithMany(s => s.Appointments)
            //    .HasForeignKey(a => a.SurgeryId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
