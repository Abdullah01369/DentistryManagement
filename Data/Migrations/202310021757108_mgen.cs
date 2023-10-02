namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bosses", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Bosses", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Bosses", "Tc", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Bosses", "Mail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Sectarians", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Sectarians", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Sectarians", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Sectarians", "Tc", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Sectarians", "Mail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Patients", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Patients", "Tc", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Patients", "Mail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Admins", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Admins", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Admins", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Messages", "MailSender", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Messages", "MailReceiver", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Messages", "Tite", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Messages", "Text", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "Text", c => c.String());
            AlterColumn("dbo.Messages", "Tite", c => c.String());
            AlterColumn("dbo.Messages", "MailReceiver", c => c.String());
            AlterColumn("dbo.Messages", "MailSender", c => c.String());
            AlterColumn("dbo.Admins", "Mail", c => c.String());
            AlterColumn("dbo.Admins", "Surname", c => c.String());
            AlterColumn("dbo.Admins", "Name", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String());
            AlterColumn("dbo.Patients", "Mail", c => c.String());
            AlterColumn("dbo.Patients", "Tc", c => c.String());
            AlterColumn("dbo.Patients", "Surname", c => c.String());
            AlterColumn("dbo.Patients", "Name", c => c.String());
            AlterColumn("dbo.Sectarians", "Mail", c => c.String());
            AlterColumn("dbo.Sectarians", "Tc", c => c.String());
            AlterColumn("dbo.Sectarians", "Surname", c => c.String());
            AlterColumn("dbo.Sectarians", "Name", c => c.String());
            AlterColumn("dbo.Sectarians", "Password", c => c.String());
            AlterColumn("dbo.Bosses", "Mail", c => c.String());
            AlterColumn("dbo.Bosses", "Tc", c => c.String());
            AlterColumn("dbo.Bosses", "Surname", c => c.String());
            AlterColumn("dbo.Bosses", "Name", c => c.String());
        }
    }
}
