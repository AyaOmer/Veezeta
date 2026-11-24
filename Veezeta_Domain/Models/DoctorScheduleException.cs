using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veezeta_Domain.Models
{
    public class DoctorScheduleException
    {
        public int Id { get; set; }
        public string DoctorId { get; set; }
        public int ClinicId { get; set; }
        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }
        // false = Blocked time / Vacation
        // true = Additional working hours

        public bool IsAvailable { get; set; }
        [Range(1, 480)]
        public int? SlotDurationMinutes { get; set; }

        [MaxLength(500)]
        public string? Reason { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties

        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; } = null!;

        [ForeignKey(nameof(ClinicId))]
        public Clinic Clinic { get; set; } = null!;
    }
}
