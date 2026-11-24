using System.ComponentModel.DataAnnotations;

namespace Veezeta_Domain.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(30)]
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        [MaxLength(256)]
        public string? Email { get; set; }

        public bool IsHospital { get; set; }
        [MaxLength(500)]
        public string? LocationLink { get; set; }

        [Required]
        [MaxLength(100)]
        public string TimeZoneId { get; set; } = "Africa/Cairo";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
        // Navigation Properties
        public ICollection<DoctorClinic> DoctorClinics { get; set; }
           = new List<DoctorClinic>();

        public ICollection<ClinicWorkingHour> WorkingHours { get; set; }
            = new List<ClinicWorkingHour>();

        public ICollection<DoctorSchedule> DoctorSchedules { get; set; }
            = new List<DoctorSchedule>();

        public ICollection<DoctorScheduleException> ScheduleExceptions { get; set; }
            = new List<DoctorScheduleException>();

        public ICollection<Appointment> Appointments { get; set; }
            = new List<Appointment>();

    }
}
