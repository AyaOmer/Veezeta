using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veezeta_Domain.Models
{
    public class Doctor
    {
        [Key]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string MedicalLicenseNumber { get; set; } = null!;

        [MaxLength(2000)]
        public string? Biography { get; set; }

        public bool IsVerified { get; set; }
        [MaxLength(500)]
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        // Navigation Properties


        public User? User { get; set; }
        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
            = new List<DoctorSpecialty>();

        public ICollection<DoctorClinic> DoctorClinics { get; set; }
            = new List<DoctorClinic>();

        public ICollection<DoctorSchedule> DoctorSchedules { get; set; }
            = new List<DoctorSchedule>();

        public ICollection<DoctorScheduleException> ScheduleExceptions { get; set; }
            = new List<DoctorScheduleException>();

        public ICollection<Appointment> Appointments { get; set; }
            = new List<Appointment>();

    }
}
