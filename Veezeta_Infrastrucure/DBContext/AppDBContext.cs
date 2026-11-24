using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Veezeta_Domain.Models;

namespace Veezeta_Infrastrucure.DBContext
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        // Doctors & Specialties
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Specialty> Specialties => Set<Specialty>();
        public DbSet<DoctorSpecialty> DoctorSpecialties => Set<DoctorSpecialty>();
        // Clinics
        public DbSet<Clinic> Clinics => Set<Clinic>();
        public DbSet<DoctorClinic> DoctorClinics => Set<DoctorClinic>();
        public DbSet<ClinicWorkingHour> ClinicWorkingHours => Set<ClinicWorkingHour>();
        // Appointments & Schedules
        public DbSet<DoctorSchedule> DoctorSchedules => Set<DoctorSchedule>();
        public DbSet<DoctorScheduleException> DoctorScheduleExceptions
            => Set<DoctorScheduleException>();
        public DbSet<Appointment> Appointments => Set<Appointment>();

        // Payments & Coupons
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<Coupon> Coupons => Set<Coupon>();
        public DbSet<CouponRedemption> CouponRedemptions
            => Set<CouponRedemption>();
        // Insurance
        public DbSet<InsuranceProvider> InsuranceProviders
            => Set<InsuranceProvider>();
        public DbSet<PatientInsurance> PatientInsurances
            => Set<PatientInsurance>();
        public DbSet<AppointmentInsurance> AppointmentInsurances
            => Set<AppointmentInsurance>();




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureIdentity(builder);
            ConfigureDoctors(builder);
            ConfigureClinics(builder);
            ConfigureSchedules(builder);
            ConfigureAppointments(builder);
            ConfigurePayments(builder);
            ConfigureInsurance(builder);
        }
        private static void ConfigureIdentity(ModelBuilder builder)
        {
            // ASP.NET Identity already configures the Identity tables.
            // No TPH inheritance is used.
        }

        private static void ConfigureDoctors(ModelBuilder builder)
        {
            builder.Entity<Doctor>()
                .HasIndex(d => d.MedicalLicenseNumber)
                .IsUnique();

            builder.Entity<Specialty>()
                .HasIndex(s => s.Name)
                .IsUnique();

            // ApplicationUser 1 : 0..1 Doctor
            builder.Entity<Doctor>()
                .HasOne(d => d.User)
                .WithOne(u => u.Doctor)
                .HasForeignKey<Doctor>(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // DoctorSpecialty composite primary key
            builder.Entity<DoctorSpecialty>()
                .HasKey(ds => new { ds.DoctorId, ds.SpecialtyId });

            builder.Entity<DoctorSpecialty>()
                .HasOne(ds => ds.Doctor)
                .WithMany(d => d.DoctorSpecialties)
                .HasForeignKey(ds => ds.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DoctorSpecialty>()
                .HasOne(ds => ds.Specialty)
                .WithMany(s => s.DoctorSpecialties)
                .HasForeignKey(ds => ds.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void ConfigureClinics(ModelBuilder builder)
        {
            // DoctorClinic composite primary key
            builder.Entity<DoctorClinic>()
                .HasKey(dc => new { dc.DoctorId, dc.ClinicId });

            builder.Entity<DoctorClinic>()
                .HasOne(dc => dc.Doctor)
                .WithMany(d => d.DoctorClinics)
                .HasForeignKey(dc => dc.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DoctorClinic>()
                .HasOne(dc => dc.Clinic)
                .WithMany(c => c.DoctorClinics)
                .HasForeignKey(dc => dc.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ClinicWorkingHour>()
                .HasOne(wh => wh.Clinic)
                .WithMany(c => c.WorkingHours)
                .HasForeignKey(wh => wh.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void ConfigureSchedules(ModelBuilder builder)
        {
            builder.Entity<DoctorSchedule>()
                .HasOne(ds => ds.Doctor)
                .WithMany(d => d.DoctorSchedules)
                .HasForeignKey(ds => ds.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DoctorSchedule>()
                .HasOne(ds => ds.Clinic)
                .WithMany(c => c.DoctorSchedules)
                .HasForeignKey(ds => ds.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DoctorScheduleException>()
                .HasOne(e => e.Doctor)
                .WithMany(d => d.ScheduleExceptions)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DoctorScheduleException>()
                .HasOne(e => e.Clinic)
                .WithMany(c => c.ScheduleExceptions)
                .HasForeignKey(e => e.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void ConfigureAppointments(ModelBuilder builder)
        {
            builder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.PatientAppointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Appointment>()
                .HasOne(a => a.Clinic)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            // One Appointment : One CouponRedemption (optional)
            builder.Entity<CouponRedemption>()
                .HasOne(cr => cr.Appointment)
                .WithOne(a => a.CouponRedemption)
                .HasForeignKey<CouponRedemption>(cr => cr.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void ConfigurePayments(ModelBuilder builder)
        {
            builder.Entity<Payment>()
                .HasOne(p => p.Appointment)
                .WithMany(a => a.Payments)
                .HasForeignKey(p => p.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CouponRedemption>()
                .HasOne(cr => cr.Coupon)
                .WithMany(c => c.Redemptions)
                .HasForeignKey(cr => cr.CouponId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CouponRedemption>()
                .HasOne(cr => cr.Patient)
                .WithMany(u => u.CouponRedemptions)
                .HasForeignKey(cr => cr.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void ConfigureInsurance(ModelBuilder builder)
        {
            builder.Entity<PatientInsurance>()
                .HasOne(pi => pi.User)
                .WithMany(u => u.PatientInsurances)
                .HasForeignKey(pi => pi.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PatientInsurance>()
                .HasOne(pi => pi.InsuranceProvider)
                .WithMany(ip => ip.PatientInsurances)
                .HasForeignKey(pi => pi.InsuranceProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AppointmentInsurance>()
                .HasOne(ai => ai.Appointment)
                .WithOne(a => a.AppointmentInsurance)
                .HasForeignKey<AppointmentInsurance>(ai => ai.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AppointmentInsurance>()
                .HasOne(ai => ai.PatientInsurance)
                .WithMany(pi => pi.AppointmentInsurances)
                .HasForeignKey(ai => ai.PatientInsuranceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}