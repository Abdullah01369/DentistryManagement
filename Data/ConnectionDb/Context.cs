using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ConnectionDb
{
    public class Context : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressClinic>  AddressClinics { get; set; }
        public DbSet<AddressPatient> AddressPatients   { get; set; }
        public DbSet<Admin> Admins   { get; set; }
        public DbSet<Boss> Bosses   { get; set; }
        public DbSet<City> Cities   { get; set; }
        public DbSet<Clinic> Clinics   { get; set; }
        public DbSet<Degree> Degrees   { get; set; }
        public DbSet<District> Districts   { get; set; }
        public DbSet<Doctor> Doctors   { get; set; }
        public DbSet<LevelSubscribeClinic>  LevelSubscribeClinics   { get; set; }
        public DbSet<Message> Messages   { get; set; }
        public DbSet<Patient> Patients   { get; set; }
        public DbSet<Paying> Payings   { get; set; }
        public DbSet<PayingClinic> PayingClinics   { get; set; }
        public DbSet<PeakRoom> peakRooms   { get; set; }
        public DbSet<Prescription> Prescriptions   { get; set; }
        public DbSet<Sectarian> Sectarians   { get; set; }
        public DbSet<Special_illness> special_Illnesses   { get; set; }
        public DbSet<SpecialTreatments> SpecialTreatments   { get; set; }
        public DbSet<Subscribing> Subscribings   { get; set; }
        public DbSet<Treatment> Treatments   { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Treatment>()
                .HasOptional(t => t.Prescription)
                .WithRequired(p => p.Treatment);
        }
    }
}
