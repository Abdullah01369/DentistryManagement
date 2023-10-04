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


            modelBuilder.Entity<Message>().Property(p => p.MailSender).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Message>().Property(p => p.Tite).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Message>().Property(p => p.MailReceiver).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Message>().Property(p => p.Text).IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Admin>().Property(p => p.Surname).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Admin>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Admin>().Property(p => p.Password).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Admin>().Property(p => p.Birthdate).IsRequired();
            modelBuilder.Entity<Admin>().Property(p => p.Mail).IsRequired();


            modelBuilder.Entity<Boss>().Property(p => p.Surname).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Boss>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Boss>().Property(p => p.Tc).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Boss>().Property(p => p.Mail).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Boss>().Property(p => p.Surname).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<Patient>().Property(p => p.Surname).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Patient>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Patient>().Property(p => p.Mail).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Patient>().Property(p => p.Tc).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<Sectarian>().Property(p => p.Surname).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Sectarian>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Sectarian>().Property(p => p.Mail).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Sectarian>().Property(p => p.Tc).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Sectarian>().Property(p => p.Password).IsRequired().HasMaxLength(100);


        }
    }
}
