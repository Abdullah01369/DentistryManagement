namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressClinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        Declaration = c.String(),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patient_Id)
                .Index(t => t.CityId)
                .Index(t => t.Patient_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        Declaration = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicId = c.Int(nullable: false),
                        PeakId = c.Int(nullable: false),
                        DegreeId = c.Int(nullable: false),
                        InWorkDate = c.DateTime(nullable: false),
                        OutWorkDate = c.DateTime(nullable: false),
                        Password = c.String(),
                        Status = c.Boolean(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Tc = c.String(),
                        Mail = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        peakroom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .ForeignKey("dbo.Degrees", t => t.DegreeId, cascadeDelete: true)
                .ForeignKey("dbo.PeakRooms", t => t.peakroom_Id)
                .Index(t => t.ClinicId)
                .Index(t => t.DegreeId)
                .Index(t => t.AddressId)
                .Index(t => t.peakroom_Id);
            
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BossId = c.Int(nullable: false),
                        AdressClinicId = c.Int(nullable: false),
                        SubscribingId = c.Int(nullable: false),
                        AddressClinic_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AddressClinics", t => t.AddressClinic_Id)
                .ForeignKey("dbo.Bosses", t => t.BossId, cascadeDelete: true)
                .ForeignKey("dbo.Subscribings", t => t.SubscribingId, cascadeDelete: true)
                .Index(t => t.BossId)
                .Index(t => t.SubscribingId)
                .Index(t => t.AddressClinic_Id);
            
            CreateTable(
                "dbo.Bosses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Tc = c.String(),
                        Mail = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subscribings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Degrees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PeakRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sectarians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InWorkDate = c.DateTime(nullable: false),
                        OutWorkDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Password = c.String(),
                        UserName = c.String(),
                        DoctorId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Tc = c.String(),
                        Mail = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Payings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TreatmentId = c.Int(nullable: false),
                        FinalPrice = c.Double(nullable: false),
                        SectarianId = c.Int(nullable: false),
                        IsPayed = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sectarians", t => t.SectarianId, cascadeDelete: true)
                .ForeignKey("dbo.Treatments", t => t.TreatmentId, cascadeDelete: true)
                .Index(t => t.TreatmentId)
                .Index(t => t.SectarianId);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        PrescriptionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Declareation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: false)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressPatientId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Tc = c.String(),
                        Mail = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AddressPatients", t => t.AddressPatientId, cascadeDelete: true)
                .Index(t => t.AddressPatientId);
            
            CreateTable(
                "dbo.AddressPatients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        Declaration = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Special_illness",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Boolean(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        MedicineDeclareation = c.String(),
                        GivingDate = c.DateTime(nullable: false),
                        DeadDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Treatments", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.SpecialTreatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Treatment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Treatments", t => t.Treatment_Id)
                .Index(t => t.Treatment_Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Tc = c.String(),
                        Mail = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LevelSubscribeClinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Month = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PayingClinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicId = c.Int(nullable: false),
                        BeginDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        LevelSubscribeClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinics", t => t.ClinicId, cascadeDelete: true)
                .ForeignKey("dbo.LevelSubscribeClinics", t => t.LevelSubscribeClinicId, cascadeDelete: true)
                .Index(t => t.ClinicId)
                .Index(t => t.LevelSubscribeClinicId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MailSender = c.String(),
                        MailReceiver = c.String(),
                        Date = c.DateTime(nullable: false),
                        Tite = c.String(),
                        Text = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PayingClinics", "LevelSubscribeClinicId", "dbo.LevelSubscribeClinics");
            DropForeignKey("dbo.PayingClinics", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.AddressClinics", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Districts", "CityId", "dbo.Cities");
            DropForeignKey("dbo.AddressClinics", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Payings", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.SpecialTreatments", "Treatment_Id", "dbo.Treatments");
            DropForeignKey("dbo.Prescriptions", "Id", "dbo.Treatments");
            DropForeignKey("dbo.Treatments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Special_illness", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "AddressPatientId", "dbo.AddressPatients");
            DropForeignKey("dbo.AddressPatients", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Treatments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Payings", "SectarianId", "dbo.Sectarians");
            DropForeignKey("dbo.Sectarians", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "peakroom_Id", "dbo.PeakRooms");
            DropForeignKey("dbo.Doctors", "DegreeId", "dbo.Degrees");
            DropForeignKey("dbo.Clinics", "SubscribingId", "dbo.Subscribings");
            DropForeignKey("dbo.Doctors", "ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.Clinics", "BossId", "dbo.Bosses");
            DropForeignKey("dbo.Clinics", "AddressClinic_Id", "dbo.AddressClinics");
            DropForeignKey("dbo.Doctors", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.PayingClinics", new[] { "LevelSubscribeClinicId" });
            DropIndex("dbo.PayingClinics", new[] { "ClinicId" });
            DropIndex("dbo.Districts", new[] { "CityId" });
            DropIndex("dbo.SpecialTreatments", new[] { "Treatment_Id" });
            DropIndex("dbo.Prescriptions", new[] { "Id" });
            DropIndex("dbo.Special_illness", new[] { "PatientId" });
            DropIndex("dbo.AddressPatients", new[] { "CityId" });
            DropIndex("dbo.Patients", new[] { "AddressPatientId" });
            DropIndex("dbo.Treatments", new[] { "DoctorId" });
            DropIndex("dbo.Treatments", new[] { "PatientId" });
            DropIndex("dbo.Payings", new[] { "SectarianId" });
            DropIndex("dbo.Payings", new[] { "TreatmentId" });
            DropIndex("dbo.Sectarians", new[] { "DoctorId" });
            DropIndex("dbo.Clinics", new[] { "AddressClinic_Id" });
            DropIndex("dbo.Clinics", new[] { "SubscribingId" });
            DropIndex("dbo.Clinics", new[] { "BossId" });
            DropIndex("dbo.Doctors", new[] { "peakroom_Id" });
            DropIndex("dbo.Doctors", new[] { "AddressId" });
            DropIndex("dbo.Doctors", new[] { "DegreeId" });
            DropIndex("dbo.Doctors", new[] { "ClinicId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.AddressClinics", new[] { "Patient_Id" });
            DropIndex("dbo.AddressClinics", new[] { "CityId" });
            DropTable("dbo.Messages");
            DropTable("dbo.PayingClinics");
            DropTable("dbo.LevelSubscribeClinics");
            DropTable("dbo.Admins");
            DropTable("dbo.Districts");
            DropTable("dbo.SpecialTreatments");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Special_illness");
            DropTable("dbo.AddressPatients");
            DropTable("dbo.Patients");
            DropTable("dbo.Treatments");
            DropTable("dbo.Payings");
            DropTable("dbo.Sectarians");
            DropTable("dbo.PeakRooms");
            DropTable("dbo.Degrees");
            DropTable("dbo.Subscribings");
            DropTable("dbo.Bosses");
            DropTable("dbo.Clinics");
            DropTable("dbo.Doctors");
            DropTable("dbo.Addresses");
            DropTable("dbo.Cities");
            DropTable("dbo.AddressClinics");
        }
    }
}
